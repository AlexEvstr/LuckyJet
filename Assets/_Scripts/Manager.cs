using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void HomeButton()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ReplayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void PauseButton()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePause()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
