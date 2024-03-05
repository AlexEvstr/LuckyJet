using UnityEngine;
using TMPro;

public class StatsPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _bestScoreText;
    [SerializeField] private TMP_Text _totalCoinsText;
    [SerializeField] private TMP_Text _totalKillsText;
    [SerializeField] private TMP_Text _totalBossesText;
    [SerializeField] private TMP_Text _totalDeathsText;

    private void Start()
    {
        UpdateStats();
    }

    public void UpdateStats()
    {
        _bestScoreText.text = GameData.BestScore.ToString();
        _totalCoinsText.text = GameData.TotalCoins.ToString();
        _totalKillsText.text = GameData.TotalKills.ToString();
        _totalBossesText.text = GameData.TotalBosses.ToString();
        _totalDeathsText.text = GameData.TotalDeaths.ToString();
    }
}
