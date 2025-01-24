using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemywaffPrefab;
    public float spawnRate = 2f; // Spawn every 2 seconds
    public float minY = -3f, maxY = 3f; // Y-axis bounds
    private float nextSpawnTime;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnEnemy()
    {
        float randomY = Random.Range(minY, maxY);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomY);
        Instantiate(EnemywaffPrefab, spawnPosition, Quaternion.identity);
    }
}
