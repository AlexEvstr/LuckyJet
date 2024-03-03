using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFireBallBehavior : MonoBehaviour
{
    private float _speed = 7.0f;

    private void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _speed);
    }
}
