using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public float moveSpeed = 1.0f;

    void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    void HandleMovement()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveHorizontal, 0, 0);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    void HandleRotation()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(0, 90, 0);
        }
    }
}