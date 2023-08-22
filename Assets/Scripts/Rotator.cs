using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float degree = 3;
    

    
    void Update()
    {
        if (GameManager.GetState() != "Loose")
        {
        transform.Rotate(new Vector3(0, 0, degree));
        }
    }
}
