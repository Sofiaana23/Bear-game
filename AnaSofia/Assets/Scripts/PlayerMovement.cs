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

    private AudioSource source;
    public AudioClip[] SFX;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
       
        
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), yVelocity, 0);

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
        if (Input.GetAxis("Horizontal") < 0)
        {
            art.transform.rotation = rotationRight.transform.rotation;
            
        }
        


        if (controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {

            yVelocity = -0.5f;
            yVelocity = jumpHeight;
            jumpCount++;   

        }
        else
        {
            if (controller.isGrounded && yVelocity <= -0.5f)
            {
                yVelocity = -0.5f;
                jumpCount = 0;
            }
            else
            {
                yVelocity += gravityValue * Time.deltaTime;
            }
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, 8.13f);

        if (jumpCount < 2 && controller.isGrounded != true && Input.GetKeyDown(KeyCode.Space) || jumpCount < 2 && controller.isGrounded != true && Input.GetKeyDown(KeyCode.W))
        {
            yVelocity = 0f;
            yVelocity = jumpHeight + .5f;
            jumpCount++;

        }

       
    }

    private void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(SFX[0]);
    }
}

