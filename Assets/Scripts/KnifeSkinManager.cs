using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSkinManager : MonoBehaviour
{
    public static Sprite KnifeSkin;

    public void OnClick(Sprite knifeSprite)
    {
        KnifeSkin= knifeSprite;
    }
}
