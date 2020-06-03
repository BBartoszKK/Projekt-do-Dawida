using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackFront : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private Animator anim;
    //private Vector2 mousePosition, playerPosition;

    void Update()
    {
        //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 playerPosition = player.transform.position;

        //Debug.DrawLine(playerPosition, mousePosition, Color.red);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Attack");
        }
    }
}
