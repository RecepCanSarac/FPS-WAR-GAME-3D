using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController characterController;
    public float speed = 10f;

    public float gravity = -9.81f;
    private Vector3 gravityVector;

    //GroundCheck
    public Transform groundCheckPoint;
    public float groundCheckRadius = 0.35f;
    public LayerMask groundLayer;

    public bool isGrounded;

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

        isGrounded = Physics.CheckSphere(groundCheckPoint.position,groundCheckRadius,groundLayer);

        if (isGrounded && gravityVector.y < 0)
        {
            gravityVector.y = -3f;
        }
    }
}
 