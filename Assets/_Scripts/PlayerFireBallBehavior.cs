using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireBallBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _enemyDestroy;
    [SerializeField] private GameObject _enemy;

    private float _speed = 5.0f;

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            GameObject destroy = Instantiate(_enemyDestroy, new Vector2(collision.transform.position.x, collision.transform.position.y), Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(destroy, 0.2f);
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("Boss"))
        {
            GameObject destroy = Instantiate(_enemyDestroy, new Vector2(collision.transform.position.x, collision.transform.position.y), Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(destroy, 0.2f);
            Destroy(gameObject);

            PlatformSpawner.isBoss = false;
            PlatformSpawner._oneCopyBoss = false;
            PlatformSpawner._oneCopyPlatforms = false;
        }
    }
}
