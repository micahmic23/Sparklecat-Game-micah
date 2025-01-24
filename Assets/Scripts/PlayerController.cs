using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Camera mainCamera;
    private Vector3 screenBounds;
    private float playerHeight;
    private float playerWidth;

    void Start()
    {
        mainCamera = Camera.main;

        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        BoxCollider2D playerCollider = GetComponent<BoxCollider2D>();
        if (playerCollider != null)
        {
            playerHeight = playerCollider.bounds.extents.y;
            playerWidth = playerCollider.bounds.extents.x;
        }
        else
        {
            Debug.LogError("Player collider is not found!");
        }
    }

    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0, verticalInput, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        ClampPlayerToCameraBounds();
    }

    void ClampPlayerToCameraBounds()
    {
        Vector3 playerPosition = transform.position;

        playerPosition.y = Mathf.Clamp(playerPosition.y, -screenBounds.y, screenBounds.y);

        playerPosition.x = Mathf.Clamp(playerPosition.x, -screenBounds.x, screenBounds.x);

        transform.position = playerPosition;
    }
}
