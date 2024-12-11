using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    private float spawnRangeX = 4.5f;
    private float spawnPosY = 150;
    private float startDelay = 2;
    private float spawnInterval = 3;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeX, -spawnRangeX), spawnPosY, 0);

        Instantiate(enemyPrefab[enemyIndex], spawnPos, enemyPrefab[enemyIndex].transform.rotation);
    }
}
