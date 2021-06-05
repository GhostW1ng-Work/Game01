using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.CoinsAmountChanged += ChangeValue;
    }

    private void OnDisable()
    {
        _player.CoinsAmountChanged -= ChangeValue;
    }

    public void ChangeValue(int value)
    { 
        _text.text = value.ToString();
    }
}
