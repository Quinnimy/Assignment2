/*
* Quinn Lamkin
* Assignment 2 Prototype 1
* color change collision, changes color to red
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to an object, wall here
public class ChangeColorOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        //When colliding with player
        if (other.gameObject.CompareTag("Player"))
        {
            //turns object red
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
