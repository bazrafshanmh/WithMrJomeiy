using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private static string _state;

    void Update()
    {
        _state = GameManager.GetState();
        if (_state == "LoadLoose")
        {
            GameManager.ChangeState("Loose");
            SceneManager.LoadScene("Loose");
        }else if(_state == "LoadMenu")
        {
            GameManager.ChangeState("Menu");
            SceneManager.LoadScene("Menu");
        }else if (_state == "LoadPlay")
        {
            GameManager.ChangeState("Play");
            SceneManager.LoadScene("Main");
        }else if (_state == "LoadStartMenu")
        {
            GameManager.ChangeState("StartMenu");
            SceneManager.LoadScene("StartMenu");
        }else if (_state == "LoadShop")
        {
            GameManager.ChangeState("Shop");
            SceneManager.LoadScene("Shop");
        }else if (_state == "LoadSettings")
        {
            GameManager.ChangeState("Settings");
            SceneManager.LoadScene("Settings");
        }else if (_state == "LoadWin")
        {
            GameManager.ChangeState("Win");
            SceneManager.LoadScene("Win");
        }
    }


    public void OnClickMenu()
    {
        GameManager.ChangeState("LoadMenu");
    }
    public void OnClickSettings()
    {
        GameManager.ChangeState("LoadSettings");
    }
    public void OnStartMenu()
    {
        GameManager.ChangeState("LoadStartMenu");
    }
    public void OnClickShop()
    {
        GameManager.ChangeState("LoadShop");
    }
    public void OnLoose()
    {
        GameManager.ChangeState("LoadLoose");
    }
    public void OnWin()
    {
        GameManager.ChangeState("LoadWin");
    }
    public void OnStartGame()
    {
        GameManager.ChangeState("LoadPlay");
    }
    public void OnExit()
    {
        Application.Quit();
    }
}
