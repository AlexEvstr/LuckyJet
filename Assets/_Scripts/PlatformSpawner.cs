using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _platforms;
    [SerializeField] private GameObject[] _bossPlatforms;

    public static bool isBoss;
    public static bool _oneCopyPlatforms;
    public static bool _oneCopyBoss;

    private int _bossIndex;

    private void Start()
    {
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
        if (ScoreCounter.Score % 5000 == 0)
        {
            isBoss = true;
            if (_oneCopyBoss == false)
            {
                StopCoroutine(SpawnPlatform());
                SpawnBoss();
                _oneCopyBoss = true;
            }
        }
        else
        {
            if (_oneCopyPlatforms == false)
            {
                StartCoroutine(SpawnPlatform());
                _oneCopyPlatforms = true;
            }
        }
    }

    private void SpawnBoss()
    {
        GameObject boss = Instantiate(_bossPlatforms[_bossIndex], new Vector2(16, 0), Quaternion.identity);
        _bossIndex++;
        if (_bossIndex == 3)
        {
            _bossIndex = 0;
        }
    }
}
