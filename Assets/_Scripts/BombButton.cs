using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombButton : MonoBehaviour
{
    public void UseBomb()
    {
        if (GameData.BombBonus != 0)
        {
            GameData.BombBonus--;
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            for (int i = 0; i < enemies.Length; i++)
            {
                Destroy(enemies[i]);
            }
        }
    }
}
