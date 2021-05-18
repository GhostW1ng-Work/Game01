using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private int _xVelocity;
    [SerializeField] private int _yVelocity;

    private Rigidbody2D _rigidBody2D;

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void MoveRight()
    {
        _rigidBody2D.velocity = new Vector2(_xVelocity, _rigidBody2D.velocity.y);      
    }

    public void MoveLeft()
    {
        _rigidBody2D.velocity = new Vector2(-_xVelocity, _rigidBody2D.velocity.y);
    }

    public void Stop()
    {
        _rigidBody2D.velocity = new Vector2(0, 0);
    }

    public void Jump()
    {

    }

}
