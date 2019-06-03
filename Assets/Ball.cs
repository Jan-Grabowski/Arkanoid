using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    [SerializeField] bool hasStarted = false;
    [SerializeField] float xPush;
    [SerializeField] float yPush;
    [SerializeField] Rigidbody2D rb;
    Vector2 paddletoBallVector;
    
    private void Start()
    {
        paddletoBallVector = transform.position - paddle1.transform.position;
        rb = GetComponent<Rigidbody2D>();
        rb.simulated = false;
    }


    private void Update()
    {
        if (!hasStarted)
        {
            LockBalltoPaddle();
            LaunchonMouseclick();
        }
    }

    private void LaunchonMouseclick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            rb.simulated = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
        }
    }

    private void LockBalltoPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddletoBallVector;
    }
}

