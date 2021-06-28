using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public Image healthBarFill;
    public int curHp;
    public int maxHp;
    public int goldToGive;

    public void Damage()
    {
        // Subtract 1 from curHP
        curHp--;
        // Update health bar
        healthBarFill.fillAmount = (float)curHp / (float)maxHp;


        if(curHp <= 0)
        {
            Defeated();
        }

    }

    public void Defeated()
    {
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
