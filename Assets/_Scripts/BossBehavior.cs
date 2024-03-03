using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    private float _speed = 5.0f;

    private void Update()
    {
        if (transform.position.x >= 4)
        {  
            transform.Translate(Vector2.left * Time.deltaTime * _speed);
        }

        if (transform.childCount == 5)
        {
            FuelController.FuelQuantity = 1.0f;
        }
        else
        {
            transform.Translate(Vector2.left * Time.deltaTime * _speed);

        }
    }
}