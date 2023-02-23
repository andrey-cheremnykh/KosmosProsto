using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] GameObject[] asteroidPrefabs;
    private void Start()
    {
        print("iji");
    }
    public void SpawnAsteroid()
    {
        print("aboba");   
        Vector3 spawnPos = transform.position;
        int astIndex = Random.Range(0,asteroidPrefabs.Length);
        Instantiate(asteroidPrefabs[astIndex], spawnPos, Quaternion.identity);
    }
}
