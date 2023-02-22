using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] GameObject[] asteroidPrefabs;
    public void SpawnAsteroid()
    {
        Vector3 spawnPos = transform.position;
        int astIndex = Random.Range(0,asteroidPrefabs.Length);
        Instantiate(asteroidPrefabs[astIndex], spawnPos, Quaternion.identity);
    }
}
