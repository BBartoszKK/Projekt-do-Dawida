using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingInUniverse : MonoBehaviour
{
    public float timer = 1f;
    [SerializeField]
    private Rigidbody2D character;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer < 0.5f)
        {
            character.AddForce(new Vector3(0, 0.1f * Time.deltaTime, 0));
        }
        if (timer > 0.5f && timer < 1f)
        {
            character.AddForce(new Vector3(0, -0.05f * Time.deltaTime, 0));
        }
        if (timer > 1f && timer < 1.5f)
        {
            character.AddForce(new Vector3(0, -0.1f * Time.deltaTime, 0));
        }
        if (timer > 1.5f && timer < 2f)
        {
            character.AddForce(new Vector3(0, 0.05f * Time.deltaTime, 0));
        }
        if (timer >= 2f)
        {
            timer = 0;
        }
    }
}
