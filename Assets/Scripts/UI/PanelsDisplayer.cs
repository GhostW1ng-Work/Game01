using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelsDisplayer : MonoBehaviour
{
    [SerializeField] private GameObject _panel;
    

    public void OpenPanel()
    {
        if(_panel != null)
        {
            _panel.SetActive(true);  
        }
    }

    public void ClosePanel()
    {
        if(_panel != null)
        {
            _panel.SetActive(false);
        }
    }
}
