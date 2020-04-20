using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleSpawnManager : MonoBehaviour
{

    public float levelHalfWidth;
    public int levelLength;
    public int spawnSpacing;
    public int spawnHeight;

    public GameObject[] spawnObjectList;

    void Start()
    {
        int DistanceFromStart = 0;
        int spawnTotal = levelLength / spawnSpacing;

        for (int i = 0; i < spawnTotal; i++)
        {
            DistanceFromStart += spawnSpacing;

            Instantiate(spawnObjectList[Random.Range(0, spawnObjectList.Length)], new Vector3(Random.Range(-levelHalfWidth, levelHalfWidth), spawnHeight, DistanceFromStart), Quaternion.identity);
        }
    }
}
