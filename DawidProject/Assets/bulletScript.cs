using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x+30f*Time.deltaTime, transform.transform.position.y, transform.position.z);
        if(transform.position.x >= 9f)
            Destroy(this.gameObject);
    }
}
