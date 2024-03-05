using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    private float _speed = 5.0f;

    private void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _speed);
    }
}
