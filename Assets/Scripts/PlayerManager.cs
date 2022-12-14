using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    CharacterController character;

    float gravity = -9.81f;
    Vector3 velocity;
    bool isGrounded;

    public Transform groundCheck;
    public float groundDistance = 0.5f;
    public LayerMask groundMask;
    public float speed;
    public float jumpForce;
    public GameObject Camera;
    public AudioSource FootStep;


    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        boobing();

    }

    public void PlayerMove()
    {
        GroundDetector();
        Jump();
       
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveY;

        character.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        character.Move(velocity * Time.deltaTime); 

    }

    public void GroundDetector()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -0.2f;
        }
    }

    public void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
            StopBoobing();
        }
    }

    void boobing()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            StartBoobing();
            FootStep.enabled = true;
        }
        else
        {
            FootStep.enabled = false;  
            StopBoobing();
        }

        
    }

    public void StartBoobing()
    {
        Camera.GetComponent<Animator>().Play("Head boobing");
    }

    public void StopBoobing()
    {
        Camera.GetComponent<Animator>().Play("New State");
    }

   
}
