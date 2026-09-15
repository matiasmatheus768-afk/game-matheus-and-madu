using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text coinText;

    private int moedas = 0;

    void Start()
    {
        AtualizarTexto();
    }

    public void AdicionarMoeda()
    {
        moedas++;
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        coinText.text = "🪙 Moedas: " + moedas;
    }
}
