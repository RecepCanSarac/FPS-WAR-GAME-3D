using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public Transform player;
    public float mouseSens = 200f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseXPos = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime; 
        float mouseYPos = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        player.Rotate(Vector3.up * mouseXPos);
    }
}
