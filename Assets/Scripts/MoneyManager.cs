using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static int Coins;
    
    void OnEnable()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            Coins = PlayerPrefs.GetInt("Score");
        }else
        {
            Coins = 0;
        }
        CollisionHandler.Collision += moneyHandler;
    }
    
    void Update()
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            Coins = PlayerPrefs.GetInt("Score");
        }else
        {
            Coins = 0;
        }
    }
    void OnDisable()
    {
        CollisionHandler.Collision -= moneyHandler;
    }

    void moneyHandler()
    {
        Coins += 1;
        GetComponent<Text>().text = Coins.ToString();
        PlayerPrefs.SetInt("Score", Coins);
    }


}
