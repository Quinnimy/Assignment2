/*
* Quinn Lamkin
* Assignment 2 Challenge 1
* keeps track of score and game state (win or loss)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{

    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //5 points to win
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }

        if(gameOver)
        {   
            //win condition text
            if (won)
            {
                textbox.text = "A Winner is You!\n Press R to Give Try Again";
            }
            //loss condition text
            else
            {
                textbox.text = "You Done Goofed and Lost!\n Press R to Try Again Buddy...";
            }
            //try again input
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
