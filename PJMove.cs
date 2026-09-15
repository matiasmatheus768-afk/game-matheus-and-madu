using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movimentação")]
    public float speed = 5f;

    [Header("Pulo")]
    public float jumpForce = 10f;
    public int maxJumps = 2;

    private Rigidbody2D rb;
    private int jumps;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumps = maxJumps;
    }

    void Update()
    {
        // Movimento horizontal
        float direction = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(
            direction * speed,
            rb.linearVelocity.y
        );

        // Pulo
        if (Input.GetKeyDown(KeyCode.Space) && jumps > 0)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                jumpForce
            );

            jumps--;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Quando tocar no chão, recupera os pulos
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumps = maxJumps;
        }
    }
}
