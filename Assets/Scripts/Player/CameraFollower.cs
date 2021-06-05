using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _player;

    private void Update()
    {
        UpdateCameraPosition();
    }

    public void UpdateCameraPosition()
    {
        transform.position = new Vector3(_player.position.x, _player.position.y, transform.position.z); 
    }
}
