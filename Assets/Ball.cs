using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    Vector2 paddletoBallVector;
    
    private void Start()
    {
        paddletoBallVector = transform.position - paddle1.transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        LockBalltoPaddle();
    }
    private void LockBalltoPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddletoBallVector;
    }
}
