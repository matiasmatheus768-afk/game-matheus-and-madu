using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private bool passou = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (passou) return;

        if (other.CompareTag("Player"))
        {
            passou = true;

            // Faz o personagem desaparecer
            Destroy(other.gameObject);

            // Congela o jogo
            Time.timeScale = 0f;
        }
    }
}
