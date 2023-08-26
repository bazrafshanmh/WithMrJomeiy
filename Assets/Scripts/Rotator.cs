using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Rotator : MonoBehaviour
{   

    public float degree = 8;
    float startTime;
    
    void Start()
    {
        RotateContinuously();
    }

    void RotateContinuously()
    {
        if (GameManager.GetState() == "Play")
        {
            transform.DORotate(new Vector3(0, 0, degree), 3f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo);
        }
    }

}
