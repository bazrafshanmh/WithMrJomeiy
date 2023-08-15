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
        Instantiate(knife, new Vector3(26.1637f, -17.1f, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        
    }
}
