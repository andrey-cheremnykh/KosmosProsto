using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGen : MonoBehaviour
{
    [SerializeField] int AstsToGen;
    [SerializeField] GameObject AstPrefab;
    [SerializeField] float MinX, MinY, MinZ;
    [SerializeField] float MaxX, MaxY, MaxZ;
    private void Awake()
    {
        GenerateAsts();
    }
    void GenerateAsts()
    {
        
        int toGen = 0;
        if (toGen >= AstsToGen) return;
        while (toGen < AstsToGen)
        {
            float RandomY = Random.Range(MinY, MaxY);
            float RandomZ = Random.Range(MinZ, MaxZ);
            float RandomX = Random.Range(MinX, MaxX);
            Vector3 randomVector = new(RandomX, RandomY, RandomZ);
            Instantiate(AstPrefab, randomVector, Quaternion.identity);
            toGen++;

        }

    }
}
