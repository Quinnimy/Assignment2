/*
* Quinn Lamkin
* Assignment 3 Challenge 2
*detects collision and adds to score if dog hit 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private ScoreDisplay scoreDisplayScript;

    private void Start()
    {
        //scoreDisplayScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Dog"))
        {
            scoreDisplayScript.score++;
        }
        Destroy(gameObject);
    }
}
