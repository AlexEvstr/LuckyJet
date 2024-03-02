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


    /// УДАЛИТЬ (для тестов)/////////////////////////////////////////////////////////////////////////////////
    public static bool _oneCopy = false;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (_oneCopy == false)
            {
                ShootFireBall();
                _oneCopy = true;
            }

        }
    }

    private void Start()
    {
        StartCoroutine(ChangeBool());
    }

    private IEnumerator ChangeBool()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.5f);
            _oneCopy = false;
        }
        
    }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////

}
