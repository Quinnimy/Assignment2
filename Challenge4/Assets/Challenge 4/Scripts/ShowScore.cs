/*
 * Quinn Lamkin
 * Assignment 7 Challenge 4
 * Shows the current wave on screen
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text currentWave;
   

    //need to get current wave
    SpawnManagerX spawnManager;


    // Start is called before the first frame update
    void Start()
    {

        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManagerX>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //display current wave on screen
        currentWave.text = "Current Wave: " + spawnManager.waveCount;
    }
}
