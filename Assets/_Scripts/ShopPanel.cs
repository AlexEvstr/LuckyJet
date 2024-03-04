using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopPanel : MonoBehaviour
{
    [SerializeField] private GameObject[] _levels;
    [SerializeField] private GameObject _maxImage;
    private int _index;
    [SerializeField] private TMP_Text _currentGemsText;
    [SerializeField] private GameObject _NotEnoughGems;

    private void OnEnable()
    {
        _index = PlayerPrefs.GetInt(gameObject.name, 0);

        CheckIndex();
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt(gameObject.name, _index);
    }

    public void BuyItem()
    {
        if (GameData.Gems >= 1000)
        {
            GameData.Gems -= 1000;
            _index++;
            CheckIndex();
        }
    }

    private void CheckIndex()
    {
        for (int i = 0; i < _index; i++)
        {
            _levels[i].SetActive(true);
        }

        if (_index == 5)
        {
            ShowMax();
        }
    }

    private void ShowMax()
    {
        _maxImage.SetActive(true);
        GetComponent<Button>().interactable = false;
    }

    private void Update()
    {
        _currentGemsText.text = GameData.Gems.ToString();

        if (GameData.Gems < 1000) _NotEnoughGems.SetActive(true);
        else _NotEnoughGems.SetActive(false);
    }

    public void IncreaseJetPackForce()
    {
        UpButton.Force += 0.2f;
        PlayerPrefs.SetFloat("Force", UpButton.Force);
    }

    public void IncreaseStamina()
    {
        UpButton.Stamina -= 0.0001f;
        PlayerPrefs.SetFloat("Stamina", UpButton.Stamina);
    }

    public void IncreaseDamage()
    {
        UpButton.Damage += 0.1f;
        PlayerPrefs.SetFloat("Damage", UpButton.Damage);
    }
}
