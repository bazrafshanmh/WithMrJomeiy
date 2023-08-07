using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    


    private void Start()
    {
        HandleStateChange();
    }

    private void OnEnable()
    {
        GameManager.StateChanged += HandleStateChange;
    }
    private void OnDisable()
    {
        GameManager.StateChanged -= HandleStateChange;
    }

    private void HandleStateChange()
    {
        var state = GameManager.GetState();
        if (state == "Loose")
        {
            Loose();
        }else if (state == "Win")
        {
            Win();
        }
    }

    void Win()
    {
        CharacterController2D.CharacterSpriteRenderer.color = Color.green;
        LooseTextController.SText.enabled = false;
        WinTextController.SText.enabled = true;
        StartTextController.SText.enabled = false;
    }void Loose()
    {
        CharacterController2D.CharacterSpriteRenderer.color = Color.red;
        LooseTextController.SText.enabled = true;
        WinTextController.SText.enabled = false;
        StartTextController.SText.enabled = false;
    }
    
}
