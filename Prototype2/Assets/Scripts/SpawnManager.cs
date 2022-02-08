/*
* Quinn Lamkin
* Assignment 3 Prototype 2
* controls spawning in animals randomly and with s key
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //put prefabs to spawn on this in inspector
    public GameObject[] prefabsToSpawn;

    //for step 3 variables for spawn pos
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    public HealthSystem healthSystem;


    private void Start()
    {
        //get a reference to health system script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();


        // InvokeRepeating("SpawnRandomPrefab", 2,1.5f);
        StartCoroutine(SpawnRandomPrefabWithCoroutine());

    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //add a 3 second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        while(!healthSystem.gameOver)
        {
            SpawnRandomPrefab();
            float randomDelay = Random.Range(0.8f, 2.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            SpawnRandomPrefab();

         
        }
    }

    void SpawnRandomPrefab()
    {
        //pick random animalc index
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate spawn pos
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn randomly selected prefab(animal)
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);

    }
}
