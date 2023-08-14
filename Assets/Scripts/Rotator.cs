using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] public float degree = 3;
    [ser]

    
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, degree));
        
    }
}
