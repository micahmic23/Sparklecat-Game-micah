using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f; // Speed of the enemy

    void Update()
    {
        // Move the enemy left
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet")) // Check if hit by a bullet
        {
            Destroy(collision.gameObject); // Destroy the bullet
            Destroy(gameObject); // Destroy the enemy
        }
        else if (collision.CompareTag("Player")) // Check if colliding with the player
        {
            Debug.Log("Player hit!");
            Destroy(gameObject); // Destroy the enemy
        }
    }
}