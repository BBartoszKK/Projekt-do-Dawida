using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerCam : MonoBehaviour
{
    [SerializeField]
    private GameObject Player;
    [SerializeField]
    private GameObject Cam;
    [SerializeField]
    private float maxYValue;

    void Update()
    {
        if (Player.transform.position.y >= maxYValue)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z), Time.deltaTime * 3);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(Player.transform.position.x, maxYValue, transform.position.z), Time.deltaTime * 3);
        }
    }
}
