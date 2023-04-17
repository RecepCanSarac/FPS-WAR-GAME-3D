using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 10f;

    public float gravity = -9.81f;
    private Vector3 gravityVector; 
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveVector = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
        characterController.Move(moveVector * speed * Time.deltaTime);

        gravityVector.y -= gravity * Time.deltaTime;
        characterController.Move(gravityVector * Time.deltaTime);
    }
}
