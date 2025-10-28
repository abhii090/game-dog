using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalprefabs;
    public float spawnRangeX = 10;
    public float spawnPosZ = 10;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }
    
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalprefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalprefabs[animalIndex], spawnpos , animalprefabs[animalIndex].transform.rotation);
    }
}