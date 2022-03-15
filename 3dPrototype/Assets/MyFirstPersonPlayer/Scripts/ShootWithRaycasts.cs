/*
* Quinn Lamkin
* Assignment 5B
* enables the gun to shoot and have the muzzleflash
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100F;
    public Camera cam;

    public float hitForce = 10f;

   

    private void Update()
    {
        if(Input.GetButtonDown("Fire1")) { Shoot(); }
    }


    //muzzleflash
    public ParticleSystem muzzleFlash;

    void Shoot()
    {

        //play particle effect at start of shoot
        muzzleFlash.Play();
        RaycastHit hitInfo;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            //get the target script off of the hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            //if a target script was found make the target take damage
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            //if it hits a rigidbody applies a force
            if(hitInfo.rigidbody!=null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }
        }
    }
}
