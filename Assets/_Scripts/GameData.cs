using UnityEngine;
using TMPro;

public class GameData : MonoBehaviour
{
    public static int Gems;
    public static int MagnetBonus;
    public static int BombBonus;
    public static int X2Bonus;

    public static int BestScore;
    public static int TotalCoins;
    public static int TotalKills;
    public static int TotalBosses;
    public static int TotalDeaths;


    [SerializeField] private TMP_Text _magnetText;
    [SerializeField] private TMP_Text _bombText;
    [SerializeField] private TMP_Text _x2Text;
    [SerializeField] private TMP_Text _gemsText;

    [SerializeField] private ScreenOrientation _screenOrientation;

    private void OnEnable()
    {
        Screen.orientation = _screenOrientation;
        Gems = PlayerPrefs.GetInt("Gems", 0);
        //////
        //////
        //Gems = 10000;
        //////
        /////
        MagnetBonus = PlayerPrefs.GetInt("MagnetBonus", 5);
        BombBonus = PlayerPrefs.GetInt("BombBonus", 5);
        X2Bonus = PlayerPrefs.GetInt("X2Bonus", 5);

        BestScore = PlayerPrefs.GetInt("BestScore", 0);
        TotalCoins = PlayerPrefs.GetInt("TotalCoins", 0);
        TotalKills = PlayerPrefs.GetInt("TotalKills", 0);
        TotalBosses = PlayerPrefs.GetInt("TotalBosses", 0);
        TotalDeaths = PlayerPrefs.GetInt("TotalDeaths", 0);

        UpButton.Force = PlayerPrefs.GetFloat("Force", 2.0f);
        UpButton.Stamina = PlayerPrefs.GetFloat("Stamina", 0.0025f);
        UpButton.Damage = PlayerPrefs.GetFloat("Damage", 0.1f);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("Gems", Gems);
        PlayerPrefs.SetInt("MagnetBonus", MagnetBonus);
        PlayerPrefs.SetInt("BombBonus", BombBonus);
        PlayerPrefs.SetInt("X2Bonus", X2Bonus);

        PlayerPrefs.SetInt("BestScore", BestScore);
        PlayerPrefs.SetInt("TotalCoins", TotalCoins);
        PlayerPrefs.SetInt("TotalKills", TotalKills);
        PlayerPrefs.SetInt("TotalBosses", TotalBosses);
        PlayerPrefs.SetInt("TotalDeaths", TotalDeaths);

        PlayerPrefs.SetFloat("Force", UpButton.Force);
        PlayerPrefs.SetFloat("Stamina", UpButton.Stamina);
        PlayerPrefs.SetFloat("Damage", UpButton.Damage);
    }

    private void Update()
    {
        _magnetText.text = MagnetBonus.ToString();
        _bombText.text = BombBonus.ToString();
        _x2Text.text = X2Bonus.ToString();
        _gemsText.text = Gems.ToString();
    }
}
