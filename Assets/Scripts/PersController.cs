using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersController : MonoBehaviour
{
    public float speed;
    public float jump;
    private float moveInput;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveInput * speed, rb.velocity.y);
    }
}
