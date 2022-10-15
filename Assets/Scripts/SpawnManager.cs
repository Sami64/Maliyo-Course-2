using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float spawnXPosition = 18;
    float spawnZPosition = 19;

    float startDelay = 2;
    float spawnInterval = 1.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
}

    void SpawnAnimals() {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnXPosition, spawnXPosition), 0, spawnZPosition);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
    }
}
