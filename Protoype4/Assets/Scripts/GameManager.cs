/*
 * Quinn Lamkin
 * Assignment 7 Prototype 4
 * handles text and game state
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //need spawnmanager for wave count
    SpawnManager spawnManager;
    public Text currentWave;
    public Text Condition;

    
    //handle player loss
    public bool gameOver = false;
    public PlayerController controller;
    public bool startText = true;

    // Start is called before the first frame update
    void Start()
    {
        
        spawnManager = GameObject.FindGameObjectWithTag("SpawnManager").GetComponent<SpawnManager>();
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
     
    }

    // Update is called once per frame
    void Update()
    {   //display current wave on screen
        currentWave.text = "Current Wave: " + spawnManager.waveNumber;

        //gmaeover condition
        if (controller.transform.position.y <-10 &&!gameOver)
        {
            
            gameOver = true;
            Condition.text = "You Lose! Press R to Restart!";
        }

        //win condition
        if(spawnManager.waveNumber>10)
        {
            gameOver = true;
            Condition.text = "You Win! Press R to Restart";

        }

        //restart function
        //Press R to Restart if game over
        if (gameOver && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }

      
    }
}
