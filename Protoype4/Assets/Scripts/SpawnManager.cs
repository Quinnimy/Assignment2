/*
 * Quinn Lamkin
 * Assignment 7 Prototype 4
 * handles spawning in icreasing amounts of enemies
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject powerUpPrefab;

    private float spawnRange = 9;


    public int enemyCount;
    public int waveNumber =1;


    // Start is called before the first frame update
    void Start()
    {
        spawnEnemyWave(waveNumber);
        spawnPowerUp(1);

    }

    private void spawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            //instantiate enemy in random postition
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }


    private void spawnPowerUp(int powerUpsToSpawn)
    {
        for (int i = 0; i < powerUpsToSpawn; i++)
        {
            //instantiate powerups in random postition
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
        }
    }


    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemyCount ==0)
        {
            waveNumber++;
            spawnEnemyWave(waveNumber);
            spawnPowerUp(1);
        }
    }
}
