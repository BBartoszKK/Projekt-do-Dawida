using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingInstantate : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private GameObject bullet;

    private void Start()
    {
        GameObject prefab1 = Instantiate(bullet);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject prefab = Instantiate(bullet);
        prefab.transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
    }
}
