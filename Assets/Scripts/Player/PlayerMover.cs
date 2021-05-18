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
       
        ChangeVelocity(_xVelocity, _rigidBody2D.velocity.y);
    }

    public void MoveLeft()
    {
        
        ChangeVelocity(-_xVelocity, _rigidBody2D.velocity.y);
    }

    public void Stop()
    { 
        ChangeVelocity(0, _rigidBody2D.velocity.y);
    }

    public void Jump()
    {
        ChangeVelocity(_rigidBody2D.velocity.x, _yVelocity);
    }

    public void ChangeVelocity(float xVelocity , float yVelocity)
    {
        _rigidBody2D.velocity = new Vector2(xVelocity, yVelocity);
    }
}
