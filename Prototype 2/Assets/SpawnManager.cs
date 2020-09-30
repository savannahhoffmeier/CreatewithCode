using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangex = 20;
    private float spawnpoz = 20;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos=new Vector3(Random.Range(-spawnRangex,spawnRangex),0,spawnpoz);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        }
    }
}

