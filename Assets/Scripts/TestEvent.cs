using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestEvent : MonoBehaviour
{
    public UnityAction Action;
    public TestListener Listener;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            Action();
    }

    private void OnEnable()
    {
        Action += Listener.DoSomething;
    }

    private void OnDisable()
    {
        Action += Listener.DoSomething;
    }
}
