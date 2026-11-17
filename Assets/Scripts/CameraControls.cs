using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraControls : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed
    Camera cam;
    Camera cam2;
   
    void Start()
    {
       
    }
 
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
 
        // Calculate the new position based on the input
        Vector3 localInput = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 worldInput = transform.TransformDirection(localInput);
 
        // Maintain the Y position while moving forward/backward
        worldInput.y = 0;
 
        // Calculate the new position while maintaining Y position
        Vector3 newPosition = transform.position + worldInput * moveSpeed * Time.deltaTime;
 
        // Assign the new position to the GameObject
        transform.position = newPosition;
 
        if(Input.GetKeyDown("space"))
        {
            cam = GameObject.Find("Main Camera").GetComponent<Camera>();
            cam2 = GameObject.Find("Second Camera").GetComponent<Camera>();
 
            if(cam.enabled == true)
            {
                cam.enabled = false;
                cam2.enabled = true;
            }
            else
            {
                cam.enabled = true;
                cam2.enabled = false;
            }
        }
    }  
}

