using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackVortexBlueCap : MonoBehaviour
{
    public Animator anim;
    private bool inRange = false;
    private bool withHammer = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            anim.SetTrigger("ToHammer");
            anim.SetTrigger("IdleHammer");
            withHammer = true;
        }
        if (Input.GetKey(KeyCode.F))
        {
            anim.SetTrigger("ToFist");
            withHammer = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Enemy"));
        {
            inRange = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        { 
            inRange = false;
        }
    }
}
