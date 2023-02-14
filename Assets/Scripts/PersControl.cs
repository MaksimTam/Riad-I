using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersControl : MonoBehaviour
{
    public float speed = 1f;
    
    public Joystick joystick;
    
    Rigidbody rb;

   


    private void Start()
    {
        
    }

    private void Update()
    {
        float movement = joystick.Horizontal;
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;
        
       
    }

    
}
