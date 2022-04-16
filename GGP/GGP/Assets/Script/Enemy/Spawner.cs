using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public GameObject spawnEffect;

    public AudioClip soundEffect;

    public bool isTimer;
    public float timeToSpawn;
    private float currentTimeToSpawn;

    void Update() {

        if (isTimer) { 
              UpdateTime();
        }
    }

    void UpdateTime() {
        if (currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else {           
            SpawnObject();         
            currentTimeToSpawn = timeToSpawn;
        }
    }

    public void SpawnObject()
    {
        ExecuteSpawnEffects();
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    private void ExecuteSpawnEffects() {
        //Instantiate(spawnEffect, transform.position, transform.rotation);
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
    
    }

}
