using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickManager : MonoBehaviour
{
    public List<float> autoClickersLastTime = new List<float>();
    public int autoClickerPrice;
    public TextMeshProUGUI quantityText;

    void Update()
    {
        // Loop until reach end of the list.
        for(int i = 0; i < autoClickersLastTime.Count; i ++)
        {
            // Checks to see if value is more than one second ago.
            if(Time.time - autoClickersLastTime[i] >= 1.0f)
            {
                autoClickersLastTime[i] = Time.time;
                EnemyManager.instance.curEnemy.Damage();
            }
        }
    }

    public void OnBuyAutoClicker()
    {
        if(GameManager.instance.gold >= autoClickerPrice)
        {
            GameManager.instance.TakeGold(autoClickerPrice);
            autoClickersLastTime.Add(Time.time);

            quantityText.text = "x: " + autoClickersLastTime.Count.ToString();
        }
    }
}
