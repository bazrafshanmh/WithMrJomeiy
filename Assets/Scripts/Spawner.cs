using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject knife;

    private void OnEnable()
    {
        CollisionHandler.Collision += KnifeSpawner;
        KnifeSkinManager.KnifeSkin = knife.GetComponent<SpriteRenderer>().sprite;
    }

    private void OnDisable()
    {
        CollisionHandler.Collision -= KnifeSpawner;
    }

    void KnifeSpawner()
    {
        if (GameManager.GetState() == "Play")
        {
            Sprite knifeSkin = KnifeSkinManager.KnifeSkin;
            knife.GetComponent<SpriteRenderer>().sprite = knifeSkin;
            GameObject instantiatedObject = Instantiate(knife, new Vector3(26.1637f, -39.31f, 0), Quaternion.Euler(Vector3.zero));
            instantiatedObject.transform.localScale = knife.transform.localScale;
        }

    }
}
