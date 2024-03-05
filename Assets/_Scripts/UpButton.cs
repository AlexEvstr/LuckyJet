using UnityEngine;
using UnityEngine.EventSystems;

public class UpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _player;

    public static float Force = 2.0f;
    public static float Stamina = 0.0025f;
    public static float Damage = 0.1f;

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
            _player.GetComponent<Rigidbody2D>().velocity = Vector2.up * Force;
            FuelController.FuelQuantity -= Stamina;
        }
    }
}

