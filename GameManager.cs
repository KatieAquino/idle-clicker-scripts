using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public int gold;
    public static GameManager instance;
    public TextMeshProUGUI goldText;

    void Awake()
    {
        instance = this;
    }

    public void AddGold(int amount)
    {
        gold += amount;
        goldText.text = "Gold: " + gold.ToString();
    }
}
