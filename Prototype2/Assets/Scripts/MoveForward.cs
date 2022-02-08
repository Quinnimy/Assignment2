/*
* Quinn Lamkin
* Assignment 3 Prototype 2
* Sends animals and food forward
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to animals and food
public class MoveForward : MonoBehaviour
{
    public float speed = 40;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
