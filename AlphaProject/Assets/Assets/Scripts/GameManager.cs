using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 100;

    // Max and min gap between tiles
    public float xRange = 4.5f;
    public float yMinGap = 0.5f;
    public float yMaxGap = 2f;
    public float maxHeight = 150f;

    void Start()
    {
        Vector3 spawnPosition = Vector3.zero;

        for (int i = 0; i < platformCount; i++)
        {
            float nextY = spawnPosition.y + Random.Range(yMinGap, yMaxGap);

            if (nextY > maxHeight)
            {
                break;
            }

            spawnPosition.y = nextY;
            spawnPosition.x = Random.Range(-xRange, xRange);

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
