using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisController : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float rotationSpeed = 100.0f;
    private Vector3 moveDirection;
    private bool isMoving;

    void Start()
    {
        isMoving = false;
        moveDirection = Vector3.down;
    }

    void Update()
    {
        HandleInput();
        MoveTetromino();
    }

    void HandleInput()
    {
        if (isMoving) return;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveDirection = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveDirection = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            RotateTetromino();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDirection = Vector3.down;
        }
    }

    void MoveTetromino()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    void RotateTetromino()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}