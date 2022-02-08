/*
* Quinn Lamkin
* Assignment 3 Prototype 2
* Player control script
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 14;

    // Update is called once per frame
    void Update()
    {
        //get horizontal input from right and left arrows or A and D keys
        horizontalInput = Input.GetAxis("Horizontal");

        //transforms horizontally with input
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keeps player in bounds
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }
}
