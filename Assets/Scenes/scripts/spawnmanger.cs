using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalprefabs;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalprefabs.Length);
        
            Instantiate(animalprefabs[animalIndex], new Vector3(0, 0, 20),

        animalprefabs[animalIndex].transform.rotation);
        }
    }
}