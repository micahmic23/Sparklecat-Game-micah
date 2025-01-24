using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public float difficultyIncreaseRate = 10f;
    private float nextDifficultyIncrease;

    void Update()
    {
        // Increase difficulty over time
        if (Time.time > nextDifficultyIncrease)
        {
            IncreaseDifficulty();
            nextDifficultyIncrease = Time.time + difficultyIncreaseRate;
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
    }

    void IncreaseDifficulty()
    {
        EnemySpawner[] spawners = FindObjectsOfType<EnemySpawner>();
        foreach (EnemySpawner spawner in spawners)
        {
            spawner.spawnRate = Mathf.Max(0.5f, spawner.spawnRate - 0.1f); // Faster spawns
        }
        Debug.Log("Difficulty Increased!");
    }
}
