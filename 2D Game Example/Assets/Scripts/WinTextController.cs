﻿using System;
using UnityEngine;
using UnityEngine.UI;

public class WinTextController : MonoBehaviour
{
    public static Text SText;
    private void Start()
    {
        SText = GetComponent<Text>();
    }













    void Enable()
    {
        SText.enabled = true;
    }
    
    void Disable()
    {
        SText.enabled = false;
    }
}
