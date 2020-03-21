using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float jumpValue;
    private SpriteRenderer spr;

    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, jumpValue));
        }
        if (Input.GetKey(KeyCode.A))
        {
            spr.flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            spr.flipX = false;
        }
    }
}
