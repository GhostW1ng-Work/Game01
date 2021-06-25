using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _xVelocity;
    [SerializeField] private float _yVelocity;

    private Rigidbody2D _rigidBody2D;

    private void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    public void MoveRight()
    {
       
        SetVelocity(_xVelocity, _rigidBody2D.velocity.y);
    }

    public void MoveLeft()
    {
        
        SetVelocity(-_xVelocity, _rigidBody2D.velocity.y);
    }

    public void Stop()
    { 
        SetVelocity(0, _rigidBody2D.velocity.y);
    }

    public void Jump()
    {
        SetVelocity(_rigidBody2D.velocity.x, _yVelocity);
    }

    private void SetVelocity(float xVelocity , float yVelocity)
    {
        _rigidBody2D.velocity = new Vector2(xVelocity, yVelocity);
    }
}
