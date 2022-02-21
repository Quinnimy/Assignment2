/*
* Quinn Lamkin
* Assignment 4 Prototype 3
* Controls the player, allows them to jump
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float jumpForce;
    public ForceMode jumpforceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    //part 2
    public Animator playerAnimator;

    public ParticleSystem explosionParticle;

    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        //set reference variables to components
        rb = GetComponent<Rigidbody>();

        //pt 2 
        playerAnimator = GetComponent<Animator>();

        //set reference to Audio Source
        playerAudio = GetComponent<AudioSource>();

        //start runnin
        playerAnimator.SetFloat("Speed_f", 1.0f);

        //video
        jumpforceMode = ForceMode.Impulse;

        //modify gravity
        if(Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //press spacebar to jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpforceMode);
            isOnGround = false;

            //part 2 
            //set trigger to play jump animation
            playerAnimator.SetTrigger("Jump_trig");

            //stop playing dirt particle on jump
            dirtParticle.Stop();

            //play jump sound effect
            playerAudio.PlayOneShot(jumpSound);
        }
    }

    //part 2


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //play dirt particle when player hits ground
            dirtParticle.Play();
        }

        else if( collision.gameObject.CompareTag("Obstacle") && !gameOver)
        {
            Debug.Log("Game Over!");
            gameOver = true;

            //part 2

            //bothered me dirt was kicked up on death still
            dirtParticle.Stop();

            //play death animation
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_1", 1);

            //play explosion particle
            explosionParticle.Play();

            //play collision sound
            playerAudio.PlayOneShot(crashSound);
        }
    }
}
