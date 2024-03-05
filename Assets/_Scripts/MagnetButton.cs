using System.Collections;
using UnityEngine;

public class MagnetButton : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private float _speed = 2.0f;

    private bool _isMagnet = false;

    public void UseMagnet()
    {
        if (GameData.MagnetBonus != 0)
        {
            GameData.MagnetBonus--;
            StartCoroutine(MagnetBehavior());
        }
    }

    private IEnumerator MagnetBehavior()
    {
        _isMagnet = true;
        yield return new WaitForSeconds(10);
        _isMagnet = false;
    }

    private void Update()
    {
        if (_isMagnet == true)
        {
            GameObject[] gems = GameObject.FindGameObjectsWithTag("Gem");
            for (int i = 0; i < gems.Length; i++)
            {
                gems[i].transform.position = Vector2.MoveTowards(gems[i].transform.position, _player.transform.position, 10 * Time.deltaTime * _speed);
            }
            GameObject[] fuel = GameObject.FindGameObjectsWithTag("Fuel");
            for (int i = 0; i < fuel.Length; i++)
            {
                //fuel[i].transform.position = _player.transform.position * Time.deltaTime * _speed;
                fuel[i].transform.position = Vector2.MoveTowards(fuel[i].transform.position, _player.transform.position, 10 * Time.deltaTime * _speed);
            }
        }
    }
}
