using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundloop : MonoBehaviour
{
    public float speed = 5f;
    private float backgroundWidth;

    void Start()
    {
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -backgroundWidth)
        {
            Vector3 newPosition = transform.position;
            newPosition.x += 2 * backgroundWidth;
            transform.position = newPosition;
        }
    }
}