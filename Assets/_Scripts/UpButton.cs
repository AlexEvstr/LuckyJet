using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _player;

    public static float _force = 3.0f;

    private bool _isTapped = false;

    public void OnPointerUp(PointerEventData eventData)
    {
        _isTapped = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isTapped = true;
    }

    private void FixedUpdate()
    {
        if (_isTapped)
        {
            _player.GetComponent<Rigidbody2D>().velocity = Vector2.up * _force;
            FuelController.FuelQuantity -= 0.0025f;
        }
    }
}

