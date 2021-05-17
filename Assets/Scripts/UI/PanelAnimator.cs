using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class PanelAnimator : MonoBehaviour
{
    private const string Open = "Open"; 
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        _animator.Play(Open);   
    }
}
