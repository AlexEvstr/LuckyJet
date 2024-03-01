using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetButton : MonoBehaviour
{
    public void UseMagnet()
    {
        if (GameData.MagnetBonus != 0)
        {
            GameData.MagnetBonus--;
        }
    }
}
