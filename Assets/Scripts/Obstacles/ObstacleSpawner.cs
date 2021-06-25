using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : Spawner
{
    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    IEnumerator SpawnObstacles()
    {
        var waitForSecondsBetweenSpawn = new WaitForSeconds(_secondsBetweenSpawn);

        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            Instantiate(_prefab, _spawnPoints[i].position, Quaternion.identity);
            yield return waitForSecondsBetweenSpawn;
        }  
    }
}
