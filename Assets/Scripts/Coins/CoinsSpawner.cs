using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : Spawner
{
    private int _coinsCount = 0;
    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;   

        if(_elapsedTime >= _secondsBetweenSpawn && _coinsCount < _spawnPoints.Length)
        {
            _coinsCount++;
            _elapsedTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            Instantiate(_prefab, _spawnPoints[spawnPointNumber]);
        }
    }
}
