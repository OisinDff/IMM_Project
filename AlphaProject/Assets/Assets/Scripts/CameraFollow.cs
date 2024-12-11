using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Follow_player : MonoBehaviour
{

    public GameObject player;

    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 0, -40);
    }
}


