using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private static string _state = "Start";
    public static Action StateChanged;

    public static void ChangeState(string state)
    {
        _state = state;
        StateChanged?.Invoke();
    }

    public static string GetState()
    {
        return _state;
    }

}
