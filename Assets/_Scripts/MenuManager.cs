using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanel; 
    [SerializeField] private GameObject _workShopPanel;
    [SerializeField] private GameObject _giftPanel;

    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettingsPanel()
    {
        _settingsPanel.SetActive(true);
    }

    public void CloseSettingsPanel()
    {
        _settingsPanel.SetActive(false);
    }

    public void OpenWorkShopPanel()
    {
        _workShopPanel.SetActive(true);
    }

    public void CloseWorkShopPanel()
    {
        _workShopPanel.SetActive(false);
    }

    public void OpenGiftPanel()
    {
        _giftPanel.SetActive(true);
    }

    public void CloseGiftPanel()
    {
        _giftPanel.SetActive(false);
    }
}
