using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 150f;
    private float lowerBound = -10f;
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
