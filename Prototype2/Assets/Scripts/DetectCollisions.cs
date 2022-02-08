/*
* Quinn Lamkin
* Assignment 3 Prototype 2
* Detects collision for projectiles
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food prefab
public class DetectCollisions : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
