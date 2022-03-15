/*
* Quinn Lamkin
* Assignment 5B
* player movement script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    //gravity variables
    public Vector3 velocity;
    public float gravity = -9.81f;
    public float gravityMultiplier = 2f;
    //groundcheck vars
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;
    //jump variable
    public float jumpHeight = 3f;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        //check if player grounded
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);


        //add jump code before we calculate gravity velocity
        if (Input.GetButtonDown("Jump")&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //add gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        //we multiply velocity by time.deltatime again to simulate gravity accelerating in a free fall
        controller.Move(velocity * Time.deltaTime);

        
        
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; //reset gravity to a low number
        }
    }

    
}
