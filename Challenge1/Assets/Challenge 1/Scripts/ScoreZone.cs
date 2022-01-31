/*
* Quinn Lamkin
* Assignment 2 Challenge 1
* triggers score increment in trigger zone
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{
    private bool activated = false;
    private void OnTriggerEnter(Collider other)
    {
        //if the player goes through it activates and increments score
        if(other.CompareTag("Player") && !activated)
        {
            //sets activation so player cant get multiple points from same goal
            activated = true;
            ScoreTracker.score++;
        }
    }
}
