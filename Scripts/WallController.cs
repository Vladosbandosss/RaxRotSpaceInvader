using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float speed = 10f;
    public float timer;

    public float minX = -8f, maxX = 8f;

    private bool canMove;

    private void Start()
    {
        RandomizeX();
        Invoke(nameof(StartMoving), timer);
    }
   
    void Update()
    {
        if (!canMove)
        {
            return;
        }
        transform.Translate(0f, 0f, -speed * Time.deltaTime);

        if (transform.position.z < -30f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 30f);

            RandomizeX();
            
        }
    }

    private void RandomizeX()
    {
        Vector3 temp = transform.position;
        temp.x = UnityEngine.Random.Range(minX, maxX);
        transform.position = temp;
    }

    void StartMoving()
    {
        canMove = true;
    }
}
