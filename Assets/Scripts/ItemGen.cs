using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGen : MonoBehaviour
{
    [SerializeField] int AstsToGen;
    [SerializeField] GameObject AstPrefab;
    [SerializeField] Vector3Int MinVector, MaxVector;
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
            int RandomX = Random.Range(MinVector.x, MaxVector.x);
            int RandomY = Random.Range(MinVector.y, MaxVector.y);
            int RandomZ = Random.Range(MinVector.z, MaxVector.z);
            Vector3 randomVector = new(RandomX, RandomY, RandomZ);
            Instantiate(AstPrefab, randomVector, Quaternion.identity);
            toGen++;

        }

    }
}
