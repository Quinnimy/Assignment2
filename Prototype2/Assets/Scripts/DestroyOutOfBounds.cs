/*
* Quinn Lamkin
* Assignment 3 Prototype 2
* destroys objects that go too far
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach to food and animals prefab
public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }


    // Update is called once per frame
    void Update()
    {
        //seperating the food from the animals goinf out of bounds
        //food case
        if ( transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        //animals
        if(transform.position.z<bottomBound)
        {
            //Debug.Log("Game Over!");


            //grab the health system script and call the take damage method 
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }
    }
}
