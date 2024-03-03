using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _platforms;
    [SerializeField] private GameObject[] _bossPlatforms;

    [SerializeField] private GameObject _gemsUI;
    [SerializeField] private GameObject _fuelBarUI;
    [SerializeField] private GameObject _bossHPBar;
    [SerializeField] private Image _bossHP;

    private GameObject _boss;

    public static bool isBoss;
    public static bool _oneCopyPlatforms;
    public static bool _oneCopyBoss;

    private int _bossIndex;

    private float _totalHp;
    public static float CurrentHpBoss;

    private void Start()
    {
        _totalHp = 1.0f;
        CurrentHpBoss = 1.0f;
        _bossHPBar.SetActive(false);
        isBoss = false;
        _oneCopyPlatforms = false;
        _oneCopyBoss = false;
    }

    public IEnumerator SpawnPlatform()
    {
        while(isBoss == false)
        {
            int index = Random.Range(0, _platforms.Length);
            GameObject platform = Instantiate(_platforms[index], new Vector2(16, Random.Range(-1f, 1f)), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }

    }

    private void Update()
    {
        if (ScoreCounter.Score % 5000 == 0 && _oneCopyBoss == false)
        {
            
            SpawnBoss();
            
        }
        else
        {
            if (_oneCopyPlatforms == false)
            {
                StartCoroutine(SpawnPlatform());
                _gemsUI.SetActive(true);
                _fuelBarUI.SetActive(true);
                _bossHPBar.SetActive(false);
                _oneCopyPlatforms = true;
            }
        }
        if (_bossHPBar.activeInHierarchy)
        {
            _bossHP.fillAmount = CurrentHpBoss / _totalHp;
        }
    }

    private void SpawnBoss()
    {
        isBoss = true;

        _gemsUI.SetActive(false);
        _fuelBarUI.SetActive(false);
        _bossHPBar.SetActive(true);
        _totalHp = 1.0f;
        CurrentHpBoss = 1.0f;

        _boss = Instantiate(_bossPlatforms[_bossIndex], new Vector2(16, 0), Quaternion.identity);

        _bossIndex++;
        if (_bossIndex == 4)
        {
            _bossIndex = 0;
        }
        _oneCopyBoss = true;
    }
}
