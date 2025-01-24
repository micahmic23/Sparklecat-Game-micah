using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroller : MonoBehaviour
{
    public float scrollSpeed = 5f;
    private Vector3 startPosition;
    private float groundWidth;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        groundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;
        if (transform.position.x <= startPosition.x - groundWidth)
        {
            transform.position = new Vector3(startPosition.x, transform.position.y, transform.position.z);
        }
    }
}
