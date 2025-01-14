﻿/*
* Quinn Lamkin
* Assignment 4  Challenge 3
* Controls player baloon
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

   

    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;

    //added for ground hit
    public AudioClip bounceSound;



    // Start is called before the first frame update
    void Start()
    {
        //added by meeee
        //set reference variables to components
        playerRb = GetComponent<Rigidbody>();


    
        //

        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
        
        //limiting movement up life previous assignment did with feeding animals
        //however it has a lot of excessivr momentum
        if (transform.position.y > 15)
        {
            transform.position = new Vector3(transform.position.x, 15, transform.position.z);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

        //if player hits ground
        if (other.gameObject.CompareTag("Ground"))
        {
            //bounce back up
            playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            //play sound effect
            playerAudio.PlayOneShot(bounceSound);
        }

    }


    /*Didnt work
    //to prevent player from going too high
    private bool isLowEnough()
    {
        if (transform.position.y > 15)
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
    */
}
