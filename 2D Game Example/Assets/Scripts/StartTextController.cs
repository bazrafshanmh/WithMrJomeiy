using System;
using UnityEngine;
using UnityEngine.UI;

public class StartTextController : MonoBehaviour
{
    public static Text SText;
    private void Start()
    {
        SText = GetComponent<Text>();
    }

    private void Update()
    {
        if (GameManager.GetState() == "Start")
        {
            Enable();
        }
        else
        {
            Disable();
        }
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
