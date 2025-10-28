using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalprefabs;
    public float spawnRangeX = 10;
    public float spawnPosZ = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 , spawnPosZ);
            int animalIndex = Random.Range(0, animalprefabs.Length);
        
            Instantiate(animalprefabs[animalIndex], spawnPos,

        animalprefabs[animalIndex].transform.rotation);
        }
    }
}