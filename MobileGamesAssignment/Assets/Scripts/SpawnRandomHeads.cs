using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomHeads : MonoBehaviour
{

    
    public static bool spawnAllowed;
    public SpawnEndless OP;
    public float randomTime;

    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnHead", 0f, randomTime);
    }

    void SpawnHead()
    {
        if (spawnAllowed)
        {
            OP.SpawnPrefab();
        }
    }

}
