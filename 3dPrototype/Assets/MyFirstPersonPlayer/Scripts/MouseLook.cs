/*
* Quinn Lamkin
* Assignment 5B
* player camera controller
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public GameObject player;
    private float verticalLookRotation = 0f;

    // Update is called once per frame
    void Update()
    {
        //gets mouse input and assigns to 2 floats
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //rotate player gameobject with horizontal mouse input
        player.transform.Rotate(Vector3.up * mouseX);
        
        //rotate camera around the x axis with vertical input
        verticalLookRotation -= mouseY;
        //clamp the rotation so the player doesnt over rotate
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        //apply rotation based on clamped input
        transform.localRotation = Quaternion.Euler(verticalLookRotation, 0f, 0f);
    }
    //hide and lock cursor to center of the screen
    private void OnApplicationFocus(bool focus)
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
