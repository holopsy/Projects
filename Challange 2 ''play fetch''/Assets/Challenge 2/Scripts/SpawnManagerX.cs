using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22f;
    private float spawnLimitXRight = 7f;
    private float spawnPosY = 30f;

    private float startDelay = 1.0f;

    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    void SpawnRandomBall()
    {
        // Randomly pick a ball
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Random X position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instantiate the chosen ball
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // Randomize next spawn interval between 3 and 5 seconds
        float spawnInterval = Random.Range(3f, 5f);
        Invoke("SpawnRandomBall", spawnInterval);
    }
}