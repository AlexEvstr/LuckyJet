using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public void ResetStats()
    {
        GameData.BestScore = 0;
        GameData.TotalCoins = 0;
        GameData.TotalKills = 0;
        GameData.TotalBosses = 0;
        GameData.TotalDeaths = 0;
        GetComponent<StatsPanel>().UpdateStats();
    }
}
