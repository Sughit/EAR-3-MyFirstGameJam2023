using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float horizontal;
    float vertical;
     public float speed = 5f;

     Rigidbody2D rb;

     void Start()
     {
        rb = GetComponent<Rigidbody2D>();
     }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        
    }
    void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(horizontal, vertical).normalized;
            rb.velocity = moveDirection * speed *Time.fixedDeltaTime;
    }
}
