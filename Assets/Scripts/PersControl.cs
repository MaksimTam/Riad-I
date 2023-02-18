using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersControl : MonoBehaviour
{
    public float speed = 1f;
    private float moveInput;
   

    public Joystick joystick;


    void Update()
    {

        float moveInput = joystick.Horizontal;
        transform.position += new Vector3(moveInput, 0, 0) * speed * Time.deltaTime;


    }
}
