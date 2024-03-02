using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    private float _speed = 5.0f;

    private GameObject _gems;
    private GameObject _fuelBarUI;
    private GameObject _bossHPBar;
    private GameObject _manager;

    private void Start()
    {
        _gems = GameObject.FindGameObjectWithTag("GemsUI");
        _gems.SetActive(false);
        _fuelBarUI = GameObject.FindGameObjectWithTag("FuelBarUI");
        _fuelBarUI.SetActive(false);
        _bossHPBar = GameObject.FindGameObjectWithTag("BossHPBar");
        _manager = GameObject.FindGameObjectWithTag("Manager");
    }

    private void Update()
    {
        FuelController.FuelQuantity = 1.0f;
        if (transform.position.x >= 4)
        {
            transform.Translate(Vector2.left * Time.deltaTime * _speed);
        }
        if (transform.childCount == 4)
        {
            CheckBoss();
        }
    }

    private void CheckBoss()
    {
        transform.Translate(Vector2.left * Time.deltaTime * _speed);
        _gems.SetActive(true);
        _fuelBarUI.SetActive(true);
        _bossHPBar.SetActive(false);

        //StartCoroutine(_manager.GetComponent<PlatformSpawner>().SpawnPlatform());
    }
}
