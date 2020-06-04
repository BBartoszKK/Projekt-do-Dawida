using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrounded : MonoBehaviour
{
    public bool isPlayerGrounded = true;

    private void OnTriggerStay2D(Collider2D collision)
    {
        isPlayerGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerGrounded = false;
    }
}
