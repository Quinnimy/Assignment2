/*
* Quinn Lamkin
* Assignment 2 Challenge 1
* Spins the propeller
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public GameObject propeller;

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(0, 0, 45);
    }
}
