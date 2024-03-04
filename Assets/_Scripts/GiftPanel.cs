using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GiftPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _currentGemsText;
    [SerializeField] private GameObject _speeningPanel;

    private void Update()
    {
        _currentGemsText.text = GameData.Gems.ToString();
    }

    public void SpinCircle()
    {
        _speeningPanel.SetActive(true);
    }
}