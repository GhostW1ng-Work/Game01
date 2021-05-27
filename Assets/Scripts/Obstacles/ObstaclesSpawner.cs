using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawner : ObjectPool
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_obstaclePrefab);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if(_elapsedTime >= _secondsBetweenSpawn)
        { 
            if(TryGetObject(out GameObject obstacle))
            {
                _elapsedTime = 0;

                int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

                SetObstacle(obstacle, _spawnPoints[spawnPointNumber].position);
            }
          
        }
    }

    private void SetObstacle(GameObject obstacle, Vector3 spawnPoint)
    {
        obstacle.SetActive(true);
        obstacle.transform.position = spawnPoint;
    }
}
