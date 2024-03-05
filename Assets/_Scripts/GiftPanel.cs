using System;
using TMPro;
using UnityEngine;

public class GiftPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentGemsText;
    [SerializeField] private GameObject _speeningPanel;

    [SerializeField] private GameObject _cantSpeen;

    private int _lastEntryDate;
    private int _currentEntryDate;

    private void Start()
    {

        _lastEntryDate = PlayerPrefs.GetInt("LastDate", -1);
        _currentEntryDate = DateTime.Now.DayOfYear;

        if (_lastEntryDate != _currentEntryDate)
        {
            _cantSpeen.SetActive(false);
        }
    }

    private void Update()
    {
        _currentGemsText.text = GameData.Gems.ToString();
    }

    public void SpinCircle()
    {
        _speeningPanel.SetActive(true);
        PlayerPrefs.SetInt("LastDate", _currentEntryDate);
    }
}