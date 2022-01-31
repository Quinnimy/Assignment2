/*
* Quinn Lamkin
* Assignment 2 Prototype 1
* camera follows player truck
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    //code from slides
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);


    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
