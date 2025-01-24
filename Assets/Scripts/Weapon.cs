using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float BulletSpeed = 10f;
    public Transform Firepoint;
    public GameObject BulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, Firepoint.position, Quaternion.identity);
        Rigidbody2D rb = Bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * BulletSpeed;
    }
}
