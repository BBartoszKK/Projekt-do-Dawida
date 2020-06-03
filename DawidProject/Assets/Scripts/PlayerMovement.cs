using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float jumpValue;
    [SerializeField]
    private float movementSpeed;
    private SpriteRenderer spr;
    [SerializeField]
    private Animator anim;
    private bool idle = true;
    private Vector3 playerPosition;
    [SerializeField]
    private float maxVelocityXright, maxVelocityXleft;
    private bool withHammer = false;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                anim.SetTrigger("Jump");
                playerPosition = transform.position;
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + jumpValue);
            }
            if (Input.GetKey(KeyCode.A))
            {
                if(withHammer == true) { anim.SetTrigger("RunWithHammer"); } else { anim.SetTrigger("Run"); }

                    spr.flipX = true;
                    if (rb.velocity.x > maxVelocityXleft)
                        rb.velocity = new Vector2(rb.velocity.x - movementSpeed, rb.velocity.y);
            }
            if (Input.GetKey(KeyCode.D))
            {
                    if (withHammer == true) { anim.SetTrigger("RunWithHammer"); } else { anim.SetTrigger("Run"); }
                    spr.flipX = false;
                    if (rb.velocity.x < maxVelocityXright)
                        rb.velocity = new Vector2(rb.velocity.x + movementSpeed, rb.velocity.y);
            }
        }
        else
        {
            if (withHammer == true) { anim.SetTrigger("IdleHammer"); } else { anim.SetTrigger("Idle"); }
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.H))
        {
            anim.SetTrigger("ToHammer");
            withHammer = true;
        }
        if (Input.GetKey(KeyCode.F))
        {
            anim.SetTrigger("ToFist");
            withHammer = false;
        }
    }
}
