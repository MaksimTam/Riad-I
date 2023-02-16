using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersControl : MonoBehaviour
{
    public float speed = 1f;
  
    public Joystick joystick;

  
    private void Update()
    {
        float movement = joystick.Horizontal;
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

    }
    
}
