using UnityEngine;

public class VibrateButton : MonoBehaviour
{
    public void MakeVibration()
    {
        if (VibrationButton.IsVibration == 1) Handheld.Vibrate();
    }
}
