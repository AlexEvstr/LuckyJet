using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameData : MonoBehaviour
{
    public static int Gems;
    public static int MagnetBonus;
    public static int BombBonus;
    public static int X2Bonus;

    [SerializeField] private TMP_Text _magnetText;
    [SerializeField] private TMP_Text _bombText;
    [SerializeField] private TMP_Text _x2Text;
    [SerializeField] private TMP_Text _gemsText;

    private void Start()
    {
        Gems = PlayerPrefs.GetInt("Gems", 0);
        MagnetBonus = PlayerPrefs.GetInt("MagnetBonus", 5);
        BombBonus = PlayerPrefs.GetInt("BombBonus", 5);
        X2Bonus = PlayerPrefs.GetInt("X2Bonus", 5);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("Gems", Gems);
        PlayerPrefs.SetInt("MagnetBonus", MagnetBonus);
        PlayerPrefs.SetInt("BombBonus", BombBonus);
        PlayerPrefs.SetInt("X2Bonus", X2Bonus);
    }

    private void Update()
    {
        _magnetText.text = MagnetBonus.ToString();
        _bombText.text = BombBonus.ToString();
        _x2Text.text = X2Bonus.ToString();
        _gemsText.text = Gems.ToString();
    }
}
