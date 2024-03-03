using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShootFireBall : MonoBehaviour
{
    [SerializeField] private GameObject _bossFireBall;

    private void Start()
    {
        StartCoroutine(ShootFireBall());
    }

    private IEnumerator ShootFireBall()
    {
        while(true)
        {
            Instantiate(_bossFireBall, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }
    }
}
