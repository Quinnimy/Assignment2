/*
* Quinn Lamkin
* Assignment 5B
* triggers win at trigger zone
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public static bool win = false;
    public Text wintext;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            win = true;
            wintext.text = "YOU WIN!!!";
        }
    }
}
