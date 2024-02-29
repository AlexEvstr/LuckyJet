using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _player;

    public static float _force = 5.0f;

    private bool _isTapped;

    public void OnPointerUp(PointerEventData eventData)
    {
        _isTapped = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _isTapped = true;
    }

    private void Update()
    {
        if (_isTapped)
        {
            _player.GetComponent<Rigidbody2D>().velocity = Vector2.up * _force;
        }
    }
}

