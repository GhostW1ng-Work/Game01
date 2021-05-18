using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]

public class PlayerInput : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        InputHorizontal();
    }

    public void InputHorizontal()
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
        else if(moveInput == 0)
        {
            _mover.Stop();
        }
    }
}
