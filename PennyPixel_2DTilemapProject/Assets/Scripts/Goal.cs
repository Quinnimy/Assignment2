/*
* Quinn Lamkin
* Assignment 5A
* detects win condition at cherry goal zone
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	//sets gameover bool to true to trigger text change.
	void OnTriggerEnter2D(Collider2D theCollider)
	{
		if (theCollider.CompareTag("Player"))
		{
			ScoreManager.gameOver = true;
		}
	}
}
