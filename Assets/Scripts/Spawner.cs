using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject _prefab;
    [SerializeField] protected Transform[] _spawnPoints;
    [SerializeField] protected float _secondsBetweenSpawn;
}
