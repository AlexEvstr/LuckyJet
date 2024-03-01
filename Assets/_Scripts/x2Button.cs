using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x2Button : MonoBehaviour
{
    public void UseX2()
    {
        if (GameData.X2Bonus != 0)
        {
            GameData.X2Bonus--;
        }
    }
}
