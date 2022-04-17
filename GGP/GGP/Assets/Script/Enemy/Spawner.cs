using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;


    public bool isTimer;
    public float timeToSpawn;
    private float currentTimeToSpawn;

    public AudioClip spawnAudio;
    public 

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
        AudioManager.current.PlaySound(spawnAudio, transform.position);
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }



}
