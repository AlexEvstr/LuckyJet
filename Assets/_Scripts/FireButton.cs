using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _playerFireBall;

    public void ShootFireBall()
    {
        Instantiate(_playerFireBall, new Vector2(_player.transform.position.x, _player.transform.position.y), Quaternion.identity); ;
    }
}
