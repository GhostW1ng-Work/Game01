using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public UnityAction<int> OnCoinsAmountChanged;

    private int _coinsAmount = 0;

    private void Awake()
    {
        OnCoinsAmountChanged?.Invoke(_coinsAmount);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coin>())
        {
            AddCoin();
            OnCoinsAmountChanged(_coinsAmount);
            Destroy(collision.gameObject);
        }
    }

    public void AddCoin()
    {
        _coinsAmount++;
        Debug.Log($"Coins Amount: {_coinsAmount}");
    }
}
