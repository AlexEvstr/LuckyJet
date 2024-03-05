using System.Collections;
using UnityEngine;

public class x2Button : MonoBehaviour
{
    [SerializeField] private GameObject _x2Text;

    public void UseX2()
    {
        if (GameData.X2Bonus != 0)
        {
            GameData.X2Bonus--;
            StartCoroutine(ShowX2());
        }
    }

    private IEnumerator ShowX2()
    {
        _x2Text.SetActive(true);
        ScoreCounter.ScoreIncreaseTime = 0.0025f;
        yield return new WaitForSeconds(5);
        _x2Text.SetActive(false);
        ScoreCounter.ScoreIncreaseTime = 0.005f;
    }
}
