using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    // Start is called before the first frame update

    void Update()
    {

        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(mousePosInUnits, transform.position.y);
        transform.position = paddlePos;

    }
}
