using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }
    private int _coinsAmount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddCoin()
    {
        _coinsAmount++;
        Debug.Log($"Coins Amount: {_coinsAmount}");
    }

    public int GetCoinsAmount()
    {
        return _coinsAmount;
    }

    
}
