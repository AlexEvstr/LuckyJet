using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _platforms;

    private void Start()
    {
        StartCoroutine(SpawnPlatform());
    }

    private IEnumerator SpawnPlatform()
    {
        while(true)
        {
            int index = Random.Range(0, _platforms.Length);
            GameObject platform = Instantiate(_platforms[index], new Vector2(16, Random.Range(-1f, 1f)), Quaternion.identity);
            yield return new WaitForSeconds(3.0f);
        }

    }
}
