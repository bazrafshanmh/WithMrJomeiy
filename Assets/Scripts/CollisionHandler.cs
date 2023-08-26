using System;
using UnityEngine;
using DG.Tweening;
public class CollisionHandler : MonoBehaviour
{
    public GameObject IceEffect;
    public static Action Collision;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        Collision?.Invoke();
        other.transform.SetParent(transform);
        KnifeController knifeController = other.gameObject.GetComponent<KnifeController>();
        knifeController.CollisionHandler();
        GameObject effect = Instantiate(IceEffect, new Vector3(26.3f, 11.25f, -0.48f), Quaternion.Euler(Vector3.zero));
        effect.transform.localScale = Vector3.one;
    }
}