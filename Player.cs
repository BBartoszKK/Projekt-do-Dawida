using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float moveSpeed;
   public float jumpHeight;
   
   public Transform groundCheck;
   public float groundCheckRadius;
   public LayerMask WhatIsGround;
   private bool grouned;
   public bool doubleJump;

    void Start()
    {
        
    }
    void FixedUpdate(){
        grouned = Physics2D.OverLapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);


    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)&& grouned)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,jumpHeight);
        }

     if(Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed,GetComponent<Rigidbody20>().velocity.y);
        }
    if(Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed,GetComponent<Rigidbody20>().velocity.y);
        }
    }
}
