using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidAll : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SpawnAsteroids();
    }
    void SpawnAsteroids()
    {
        Asteroid[] asts = FindObjectsOfType<Asteroid>();
        for (int i = 0; i < asts.Length; i++)
        {
            asts[i].SpawnAsteroid();
        }
    }
}
