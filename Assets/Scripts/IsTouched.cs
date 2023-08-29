using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTouched : MonoBehaviour
{
    public void OnTouch()
    {
        KnifeController.isTouched = true;
        Debug.Log("Touched");
    }
}