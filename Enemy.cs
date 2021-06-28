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
    public Animation anim;

    public void Damage()
    {
        // Subtract 1 from curHP
        curHp--;
        // Update health bar
        healthBarFill.fillAmount = (float)curHp / (float)maxHp;
        anim.Stop();
        anim.Play();


        if(curHp <= 0)
        {
            Defeated();
        }

    }

    public void Defeated()
    {
        GameManager.instance.AddGold(goldToGive);
        EnemyManager.instance.DefeatEnemy(gameObject);
    }
}
