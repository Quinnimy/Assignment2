/*
* Quinn Lamkin
* Assignment 4 Challnge 3
* Increments score when money hit
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyAddScore : MonoBehaviour
{
    private UIManagerX uIManager;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManagerX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
