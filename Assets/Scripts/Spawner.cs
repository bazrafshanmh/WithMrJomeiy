using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject knife;

    private void OnEnable()
    {
        CollisionHandler.Collision += KnifeSpawner;
    }

    private void OnDisable()
    {
        CollisionHandler.Collision -= KnifeSpawner;
    }

    void KnifeSpawner()
    {
        GameObject instantiatedObject = Instantiate(knife, new Vector3(26.1637f, -22.7f, 0), Quaternion.Euler(new Vector3(-5.564f, 2.52617f, 0)));
        instantiatedObject.transform.localScale =  new Vector3(6.208699f, 3.229203f, 2.6f);


    }
}