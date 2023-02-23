using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector3;
using Vector3 = UnityEngine.Vector3;

[RequireComponent(typeof(Rigidbody))]
public class PersControl : MonoBehaviour
{

    [SerializeField] private AudioSource runSound;
    [SerializeField] private AudioSource jumpSound;

    public float speed = 1f;
    public float jump;
    private float moveInput;
    private bool facingRight = true;
    public float stop;
  
    private Rigidbody rb;
   
    public Joystick joystick;
    private Animator anim;
    private bool isGrounded;
    public Transform _GroundChackObject;
    private float checkRadius = 0.3f;


    private void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();


        FixedUpdate();
    }


    private void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);



        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            
            Flip();
        }
        

        if (moveInput == 0)
        {
            runSound.Play();
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }

    }

    public void OnJumpButtonDown()
    {

        if (isGrounded == true)
        {
            isGrounded = false;
            rb.AddForce(Vector3.up * 100 * jump);
            anim.SetTrigger("takeOff");
        }
    }

    private void Update()
    {
        float verticalMove = joystick.Vertical;

        isGrounded = Physics.Raycast(_GroundChackObject.transform.position, Vector3.down, checkRadius);

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }
        else
        {
            jumpSound.Play();
            anim.SetBool("isJumping", true);
        }
    }

    void Flip()
    {

            facingRight = !facingRight;
            Vector2 Scaler = transform.localScale;

            Scaler.z *= -1;
            transform.localScale = Scaler;

    }
}