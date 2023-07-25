using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float horizontal;
    float vertical;
     public float speed = 500f;
     float speed2;
     float sprint;
     Vector2 lookDirection;
    float lookAngle;

     Rigidbody2D rb;

     void Start()
     {
        rb = GetComponent<Rigidbody2D>();
        speed2=speed;
        sprint=speed*2;
     }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        lookDirection = new Vector2(lookDirection.x - transform.position.x, lookDirection.y - transform.position.y);
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, lookAngle);
        
        //trebuie sa renuntam la sprintul tau pentru binele tuturor
        
        // if(Input.GetKey(KeyCode.LeftShift))
        //         speed=sprint;

        // else
        //     speed=speed2;
        
    }
    void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(horizontal, vertical).normalized;
            rb.velocity = moveDirection * speed *Time.fixedDeltaTime;
    }
}

