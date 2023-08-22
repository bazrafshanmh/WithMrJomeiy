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
        if (GameManager.GetState() == "Play")
        {
        GameObject instantiatedObject = Instantiate(knife, new Vector3(26.1637f, -39.31f, 0), Quaternion.Euler(Vector3.zero));
        instantiatedObject.transform.localScale =  new Vector3(6.208699f, 3.229203f, 2.6f);
        }

    }
}
