/*
* Quinn Lamkin
* Assignment 3 Prototype 2
* Handles shooting food
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to player
public class ShootPrefab : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
