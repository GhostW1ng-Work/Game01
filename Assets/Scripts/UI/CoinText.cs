using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    public static CoinText singleton { get; private set; }
    [SerializeField] private TMP_Text _text;

    private void Awake()
    {
        singleton = this;
    }

    public void ChangeValue(int value)
    {
        _text.text = value.ToString();
    }

}
