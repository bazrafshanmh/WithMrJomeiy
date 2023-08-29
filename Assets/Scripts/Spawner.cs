using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject knife;

    private void OnEnable()
    {
        CollisionHandler.Collision += KnifeSpawner;
        
    }

    private void OnDisable()
    {
        CollisionHandler.Collision -= KnifeSpawner;
    }
    void Update()
    {
        knife.GetComponent<SpriteRenderer>().sprite = KnifeSkinManager.Knife.GetComponent<SpriteRenderer>().sprite;
    }
    void KnifeSpawner()
    {
        if (GameManager.GetState() == "Play")
        {
            Sprite knifeSkin = KnifeSkinManager.Knife.GetComponent<SpriteRenderer>().sprite;
            knife.GetComponent<SpriteRenderer>().sprite = knifeSkin;
            GameObject instantiatedObject = Instantiate(knife, new Vector3(26.1637f, -39.31f, 0), Quaternion.Euler(Vector3.zero));
            instantiatedObject.transform.localScale = knife.transform.localScale;
        }

    }
}
