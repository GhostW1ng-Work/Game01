using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.CoinAdded += OnCoinAdded;
    }

    private void OnDisable()
    {
        _player.CoinAdded -= OnCoinAdded;
    }

    public void OnCoinAdded(int coinsAmount)
    { 
        _text.text = coinsAmount.ToString();
    }
}
