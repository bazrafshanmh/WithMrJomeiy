using System;
using UnityEngine;
using DG.Tweening;
public class CollisionHandler : MonoBehaviour
{
    public GameObject IceEffect;
    public GameObject Effect1;
    public GameObject Effect2;
    public GameObject Effect3;
    public GameObject Effect4;
    public GameObject Effect5;
    public static Action Collision;
    private int effectNum = 1;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (effectNum == 1)
        {
            Instantiate(Effect1);
        }
        if (effectNum == 2)
        {
            Instantiate(Effect2);
        }
        if (effectNum == 3)
        {
            Instantiate(Effect3);
        }
        if (effectNum == 4)
        {
            Instantiate(Effect4);
        }
        if (effectNum == 5)
        {
            Instantiate(Effect5);
        }

        Collision?.Invoke();
        other.transform.SetParent(transform);
        KnifeController knifeController = other.gameObject.GetComponent<KnifeController>();
        knifeController.CollisionHandler();
        GameObject effect = Instantiate(IceEffect, new Vector3(26.3f, 11.25f, -0.48f), Quaternion.Euler(Vector3.zero));
        effect.transform.localScale = Vector3.one;
    effectNum++;
    }
}