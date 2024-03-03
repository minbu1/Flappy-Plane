using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0, spawnRate);
    }

    void SpawnPipe()
    {
        Instantiate(pipePrefab, transform.position, Quaternion.identity);
    }


}
