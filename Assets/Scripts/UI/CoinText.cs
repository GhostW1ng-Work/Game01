using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.CoinAdded += ChangeCoinsAmount;
    }

    private void OnDisable()
    {
        _player.CoinAdded -= ChangeCoinsAmount;
    }

    public void ChangeCoinsAmount(int coinsAmount)
    { 
        _text.text = coinsAmount.ToString();
    }
}
