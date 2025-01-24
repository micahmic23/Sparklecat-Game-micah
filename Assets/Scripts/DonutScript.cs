using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}
