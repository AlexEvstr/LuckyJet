using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeeningBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _circle;

    private float _speed;
    private bool _mark;

    private void Start()
    {
        _mark = false;
        _speed = Random.Range(1, 4);
    }

    private void Update()
    {
        if (_speed >= 0.001)
        {
            _circle.transform.transform.Rotate(0, 0, 360 * _speed * Time.deltaTime);
            _speed -= 0.001f;
        }
        if (_speed < 0.001f && _mark == false)
        {
            CheckPrize();
            _mark = true;
        }
    }

    private void CheckPrize()
    {
        if ((_circle.transform.localEulerAngles.z <= 12 && _circle.transform.localEulerAngles.z >= 0) ||
            (_circle.transform.localEulerAngles.z <= 365 && _circle.transform.localEulerAngles.z >= 348) ||
            (_circle.transform.localEulerAngles.z <= 237 && _circle.transform.localEulerAngles.z >= 213))
        {
            Debug.Log("bomb");
        }
        else if ((_circle.transform.localEulerAngles.z <= 103 && _circle.transform.localEulerAngles.z >= 78) ||
                (_circle.transform.localEulerAngles.z <= 192 && _circle.transform.localEulerAngles.z >= 168) ||
                (_circle.transform.localEulerAngles.z <= 326 && _circle.transform.localEulerAngles.z >= 302))
        {
            Debug.Log("magnet");
        }
        else if ((_circle.transform.localEulerAngles.z <= 57 && _circle.transform.localEulerAngles.z >= 34) ||
                (_circle.transform.localEulerAngles.z <= 148 && _circle.transform.localEulerAngles.z >= 123) ||
                (_circle.transform.localEulerAngles.z <= 282 && _circle.transform.localEulerAngles.z >= 258))
        {
            Debug.Log("x2");
        }
        else
        {
            Debug.Log("empty");
        }
        Debug.Log(_circle.transform.localEulerAngles.z);
    }
}
