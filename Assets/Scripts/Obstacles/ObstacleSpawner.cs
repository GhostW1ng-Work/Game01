using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstaclePrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        var waitForSecondsBetweenSpawn = new WaitForSeconds(_secondsBetweenSpawn);

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_obstaclePrefab, _spawnPoints[i].position, Quaternion.identity);
            yield return waitForSecondsBetweenSpawn;
        }  
    }
}
