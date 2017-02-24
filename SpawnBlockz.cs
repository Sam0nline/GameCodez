using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockz : MonoBehaviour {

    public GameObject BlockSpawner;
    public float spawnTime = 25;
    int time = 50;
    public Transform[] spawnPoints;

	void Start ()
    {
        
    }

	void Update ()
    {
        spawnTime--;
        if (spawnTime < 0) {
            
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);

            Instantiate(BlockSpawner, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            spawnTime = time;
        }
    }
}
