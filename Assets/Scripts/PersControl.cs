using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersControl : MonoBehaviour
{
    public float speed = 1f;
    public float jump = 1f;
    private Rigidbody rigidbody;

  
    public Joystick joystick;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float verticalMove = joystick.Vertical;
        transform.position += new Vector3(verticalMove, 0) * jump * Time.deltaTime;

        float movement = joystick.Horizontal;
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

    }
    
}
