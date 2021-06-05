using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Jump = "Jump";

    private PlayerMover _mover;
    private bool _isGrounded;

   

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        UpdateHorizontalInput();
        UpdateJumpInputAndCheckIsGrounded();
    }

    public void OnCollisionEnter2D()
    {
        _isGrounded = true;
    }

    public void UpdateHorizontalInput()
    {
        float moveInput = Input.GetAxis(Horizontal);
        
        if (moveInput > 0)
        {
            _mover.MoveRight();
        }
        else if (moveInput < 0)
        {
            _mover.MoveLeft();
        }     
        else
        {
            _mover.Stop();
        }
    }

    public void UpdateJumpInputAndCheckIsGrounded()
    {
        float jumpInput = Input.GetAxis(Jump);

        if (jumpInput > 0 && _isGrounded == true)
        {
            _mover.Jump();
            _isGrounded = false;
        }
    }
}
