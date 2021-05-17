using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelClosers : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void ClosePanel()
    {
        if(_panel != null)
        {
            _panel.SetActive(false);
        }
    }
}
