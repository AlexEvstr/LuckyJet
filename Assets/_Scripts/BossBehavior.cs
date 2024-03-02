using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    private float _speed = 5.0f;

    private void Start()
    {
        GameObject gems = GameObject.FindGameObjectWithTag("GemsUI");
        gems.SetActive(false);
        GameObject fuelBar = GameObject.FindGameObjectWithTag("FuelBarUI");
        fuelBar.SetActive(false);
    }

    private void Update()
    {
        if (transform.position.x >= 4)
            transform.Translate(Vector2.left * Time.deltaTime * _speed);
    }
}
