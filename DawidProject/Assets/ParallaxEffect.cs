using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToTransform;

    [SerializeField]
    private float parallaxValue;

    [SerializeField]
    private int orderLayer;

    private SpriteRenderer spr;

    [SerializeField]
    private float distanceAmount;

    [SerializeField]
    private GameObject player;


    private void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.sortingOrder = orderLayer;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x + parallaxValue * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x - parallaxValue * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if(player.transform.position.x + transform.position.x >= distanceAmount)
        {
            transform.position = new Vector3(transform.position.x - 90f, transform.position.y, transform.position.z);
        }
        if(player.transform.position.x - transform.position.x >= distanceAmount)
        {
            transform.position = new Vector3(transform.position.x + 90f, transform.position.y, transform.position.z);
        }
    }
}
