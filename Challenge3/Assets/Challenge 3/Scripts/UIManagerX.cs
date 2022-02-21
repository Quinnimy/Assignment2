/*
* Quinn Lamkin
* Assignment 4 Chellange 3
* Handles showing the score and win/loss messages
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerX : MonoBehaviour
{

    public int score = 0;
    public Text scoreText;

    public PlayerControllerX playerControllerScript;

    public bool won = false;
    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }

        scoreText.text = "Score : 0";
    }

    // Update is called once per frame
    void Update()
    {
        //display score until game is over
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //loss condition: hit bomb 
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to try again!";
        }

        //win condition: 30 points
        if (score >= 30)
        {
            playerControllerScript.gameOver = true;
            won = true;

            // playerControllerScript.StopRunning();

            scoreText.text = "You Win!" + "\n" + "Press R to try again!";
        }

        //Press R to Restart if game over
        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }
}
