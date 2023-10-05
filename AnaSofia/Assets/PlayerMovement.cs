using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed;
    public GameObject art;

    public float yVelocity = 0f;
    public float jumpHeight = 5f;
    public float gravityValue = -9.8f;
    public float jumpCount = 0;
    public GameObject rotationLeft;
    public GameObject rotationRight;

    public Animator animator;

    void Update()
    {

        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), yVelocity, 0);

        //Debug.Log(move);

        //if (move.x >= .1f)
        //{
        //    this.transform.Rotate(0,0,0);
        //}

        //if (move.x <= 1f)
        //{
        //    this.transform.Rotate(180, 0, 0);
        //}

        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move.x == 0)
        {
            animator.SetBool("IsMoving", false);
        }
        else
        {
            animator.SetBool("IsMoving", true);
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            art.transform.rotation = rotationLeft.transform.rotation;
        }
        else
        {
            art.transform.rotation = rotationRight.transform.rotation;
        }
        


        if (controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {

            yVelocity = 0f;
            yVelocity = jumpHeight;
            

        }
        else
        {
            if (controller.isGrounded && yVelocity <= 0f)
            {
                yVelocity = 0f;
            }
            else
            {
                yVelocity += gravityValue * Time.deltaTime;
            }
        }

        if (jumpCount < 2 && controller.isGrounded != true && Input.GetKeyDown(KeyCode.Space) || jumpCount < 2 && controller.isGrounded != true && Input.GetKeyDown(KeyCode.W))
        {
            yVelocity = 0f;
            yVelocity = jumpHeight + .5f;
            
        }
    }
}

