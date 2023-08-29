using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSkinManager : MonoBehaviour
{
    public GameObject _knife_temp;
    public static GameObject Knife;
    
    void Awake()
    {
        Knife = _knife_temp;
    }
    public void OnClick(Sprite knifeSprite)
    {
        Knife.GetComponent<SpriteRenderer>().sprite = knifeSprite;
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")-30);
    }
}
