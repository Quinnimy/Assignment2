/*
* Quinn Lamkin
* Assignment 2
* triggers the win text
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerEnterTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("triggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
