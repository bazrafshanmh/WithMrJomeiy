using UnityEngine;
using DG.Tweening;
using Unity.Collections.LowLevel.Unsafe;

public class KnifeController : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float Number;
    private bool _collision = false;
    private bool _pressed = false;
    private static string _state;
    private Sprite knifeSprite = Spawner.knife.GetComponent<SpriteRenderer>().sprite;
    void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = knifeSprite;
    }
    void Update()
    {
        _state = GameManager.GetState();
        if (_state == "Play")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _pressed = true;
            }
            if (_pressed && !_collision)
            {
                transform.position += new Vector3(0, speed, 0);

            }
        }

        
    
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "knife")
        {
            GameManager.ChangeState("LoadLoose");
        }
        
    }
    public void CollisionHandler()
    {
        _collision = !_collision;
    }
}
