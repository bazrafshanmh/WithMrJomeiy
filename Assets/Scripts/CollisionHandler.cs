using System;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Serialization;


public class CollisionHandler : MonoBehaviour
{


    
    public GameObject IceEffect;
    public GameObject effect1;
    public GameObject effect2;
    public GameObject effect3;
    public GameObject effect4;
    public GameObject effect5;
    public static Action Collision;
    private int effectNum;
    private System.Random rnd = new System.Random();
    private List<GameObject> effects = new List<GameObject>();

    private void Awake()
    {
        effects.Add(effect1);
        effects.Add(effect2);
        effects.Add(effect3);
        effects.Add(effect4);
        effects.Add(effect5);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        effectNum = rnd.Next(0, 5);
        Instantiate(effects[effectNum]);

        Collision?.Invoke();
        other.transform.SetParent(transform);
        KnifeController knifeController = other.gameObject.GetComponent<KnifeController>();
        knifeController.CollisionHandler();
        GameObject effect = Instantiate(IceEffect, new Vector3(26.3f, 11.25f, -0.48f), Quaternion.Euler(Vector3.zero));
        effect.transform.localScale = Vector3.one;
    }
}