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
    [SerializeField]
    private GameObject _partner;
    private IsGrounded sc;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sc = _partner.GetComponent<IsGrounded>();
    }

    void Update()
    {
        if(rb.velocity.y >= 15)
        {
            rb.velocity = new Vector2(rb.velocity.x, 15f);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            Move();
            ResetTriggers();
        }
        else
        {
            ResetTriggers();
            Idle();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            anim.SetTrigger("ToHammer");
            withHammer = true;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("ToFist");
            withHammer = false;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    private void Idle()
    {
        if (withHammer == true) { anim.SetTrigger("IdleHammer"); }
        else { anim.SetTrigger("Idle"); }
        rb.velocity = new Vector2(0, rb.velocity.y);
    }

    private void Move()
    {
        if (sc.isPlayerGrounded == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                anim.ResetTrigger("Jump");
                anim.SetTrigger("Jump");
                playerPosition = transform.position;
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y + jumpValue);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (withHammer == true) { anim.SetTrigger("RunWithHammer"); } else { anim.SetTrigger("Run"); }

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

    private void Attack()
    {
        if(withHammer == false)
        {
            anim.SetTrigger("AttackFist");
        }
        else if(withHammer == true)
        {
            anim.SetTrigger("AttackHammer");
        }
    }

    private void ResetTriggers()
    {
        anim.ResetTrigger("AttackHammer");
        anim.ResetTrigger("AttackFist");
    }
}
