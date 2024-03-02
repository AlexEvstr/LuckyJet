using System.Collections;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    public static int Score;
    public static float ScoreIncreaseTime = 0.005f;

    private void Start()
    {
        Score = 0;
        StartCoroutine(ScoreIncrease());
    }

    private void Update()
    {
        ShowScore();
    }

    private void ShowScore()
    {
        if (Score < 10 && Score >= 0)
        {
            _scoreText.text = $"00000000{Score}";
        }
        else if (Score >= 10 && Score < 100)
        {
            _scoreText.text = $"0000000{Score}";
        }
        else if (Score >= 100 && Score < 1000)
        {
            _scoreText.text = $"000000{Score}";
        }
        else if (Score >= 1000 && Score < 10000)
        {
            _scoreText.text = $"00000{Score}";
        }
        else if (Score >= 10000 && Score < 100000)
        {
            _scoreText.text = $"0000{Score}";
        }
        else if (Score >= 100000 && Score < 1000000)
        {
            _scoreText.text = $"000{Score}";
        }
        else if (Score >= 1000000 && Score < 10000000)
        {
            _scoreText.text = $"00{Score}";
        }
        else if (Score >= 10000000 && Score < 100000000)
        {
            _scoreText.text = $"0{Score}";
        }
        else if (Score >= 100000000 && Score < 1000000000)
        {
            _scoreText.text = $"{Score}";
        }
    }

    private IEnumerator ScoreIncrease()
    {
        while (true)
        {
            Score++;
            yield return new WaitForSeconds(ScoreIncreaseTime);
        }
    }
}
