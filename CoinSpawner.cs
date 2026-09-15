using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public float tempoEntreMoedas = 2f;

    public float minX = -8f;
    public float maxX = 8f;

    public float minY = -2f;
    public float maxY = 3f;

    void Start()
    {
        InvokeRepeating("CriarMoeda", 1f, tempoEntreMoedas);
    }

    void CriarMoeda()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);

        Vector2 posicao = new Vector2(x, y);

        Instantiate(coinPrefab, posicao, Quaternion.identity);
    }
}
