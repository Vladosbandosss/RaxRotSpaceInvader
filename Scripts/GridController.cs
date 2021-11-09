using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    public float speed = 2f;
    private float positionY = 0f;

    private Material mat;

    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }

   
    void Update()
    {
        MoveGrid();
    }

    private void MoveGrid()
    {
        positionY += speed * Time.deltaTime;
        if (positionY > 40)
        {
            positionY -= 40f;
        }

        mat.mainTextureOffset = new Vector2(0f, positionY);
    }
}
