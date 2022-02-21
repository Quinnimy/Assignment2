/*
* Quinn Lamkin
* Assignment 4 Prototype 3
* Repeats the background like fred flinstones running by
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        //svae the start positio of the background to a vector3 variable
        startPosition = transform.position;

        //set the repeatwidth ti half of the width of the bg using the boxcollider
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //if the bg is further to the left than the repeatwidth, reset it to its start pos
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
