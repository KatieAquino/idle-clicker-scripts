using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldText;

    // Array that holds all of the different backgrounds.
    public Sprite[] backgrounds;
    // Current index to go through each element of the sprite array.
    private int curBackground;
    // How many enemy are needed to defeat until background changes.
    private int enemiesUntilBGChange = 5;
    public Image backgroundImage;
    public static GameManager instance;
    

    void Awake()
    {
        instance = this;
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = "Gold: " + gold.ToString();
    }

    public void TakeGold(int amount)
    {
        gold -= amount;
        goldText.text = "Gold: " + gold.ToString();
    }

    public void BackgroundCheck()
    {
        enemiesUntilBGChange--;

        if (enemiesUntilBGChange == 0)
        {
            curBackground++;
            enemiesUntilBGChange = 5;
        }

        if(curBackground >= backgrounds.Length)
        {
            curBackground = 0;
        }

        backgroundImage.sprite = backgrounds[curBackground];
    }
}
