using System;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    
    public static Action Collision;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        Collision?.Invoke();
        other.transform.SetParent(transform);
        KnifeController knifeController = other.gameObject.GetComponent<KnifeController>();
        knifeController.CollisionHandler();
        Debug.Log("LOG");
    

    }
}