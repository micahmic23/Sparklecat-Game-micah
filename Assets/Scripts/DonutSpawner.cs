using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DonutSpawner : MonoBehaviour
{
    public GameObject donutPrefab;
    public float spawnRate = 2f;
    public float minY = -3f;
    public float maxY = 3f;
    public float spawnX = 10f;
    public float donutSpeed = 5f;
    public float despawnX = -15f;
    private float nextSpawnTime = 0f;

    // Update is called once per frame
    void Update()
    {
        nextSpawnTime += Time.deltaTime;
        if (nextSpawnTime >= spawnRate)
        {
            SpawnDonut();
            nextSpawnTime = 0f;
        }
    }

    void SpawnDonut()
    {
        float randomY = Random.Range(minY, maxY);
        UnityEngine.Vector2 spawnPosition = new UnityEngine.Vector2(10f, randomY);
        GameObject donut = Instantiate(donutPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rb = donut.GetComponent<Rigidbody2D>();
        Backgroundloop scrollable = donut.AddComponent<Backgroundloop>();
        scrollable.speed = donutSpeed;
    }
}
