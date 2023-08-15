using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    public static Action StateChanged;
    public static string state;
    public static void ChangeState(string _state)
    {
        state = _state;
        StateChanged?.Invoke();
    }
    public static string GetState()
    {
        return state;
    }
}
