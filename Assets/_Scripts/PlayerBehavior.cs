using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private GameObject _playerDestroy;
    [SerializeField] private GameObject _gameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("BossFireBall"))
        {
            GameObject destroy = Instantiate(_playerDestroy, new Vector2((collision.gameObject.transform.position.x + transform.position.x) / 2, (collision.gameObject.transform.position.y + transform.position.y) / 2), Quaternion.identity);
            StartCoroutine(ShowGameOverPanel());

        }
        else if (collision.gameObject.CompareTag("Gem"))
        {
            GameData.Gems++;
            GameData.TotalCoins++;
            Destroy(collision.gameObject);
        }

        else if (collision.gameObject.CompareTag("Fuel"))
        {
            Destroy(collision.gameObject);
            FuelController.FuelQuantity += 0.25f;
            if (FuelController.FuelQuantity > 1)
            {
                FuelController.FuelQuantity = 1;
            }
        }
    }

    private IEnumerator ShowGameOverPanel()
    {
        yield return new WaitForSeconds(0.05f);
        _gameOverPanel.SetActive(true);
        GameData.TotalDeaths++;
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (FuelController.FuelQuantity <= 0)
        {
            _gameOverPanel.SetActive(true);
            GameData.TotalDeaths++;
            Time.timeScale = 0;
        }
    }
}
