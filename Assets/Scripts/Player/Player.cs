using UnityEngine;
using UnityEngine.Events;
using IJunior.TypedScenes;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _coins = 0;

    public event UnityAction<int> CoinAdded;

    private void Awake()
    {
        CoinAdded?.Invoke(_coins);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coin>())
        {
            AddCoin(); 
            Destroy(collision.gameObject);
        }
    }

    private void AddCoin()
    {
        _coins++;
        CoinAdded(_coins);
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        Menu.Load();
    }
}
