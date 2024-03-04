using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationButton : MonoBehaviour
{
    [SerializeField] private GameObject _on;
    [SerializeField] private GameObject _off;

    public static int IsVibration;

    private void Start()
    {
        float vibration = PlayerPrefs.GetFloat("sound", 1);

        if (vibration == 1) TurnOn();

        else TurnOff();
    }

    public void TurnOff()
    {
        _on.SetActive(false);
        _off.SetActive(true);
        IsVibration = 0;
        PlayerPrefs.SetFloat("Vibtation", IsVibration);
    }

    public void TurnOn()
    {
        _off.SetActive(false);
        _on.SetActive(true);
        IsVibration = 1;
        PlayerPrefs.SetFloat("Vibtation", IsVibration);
    }
}
