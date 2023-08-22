using UnityEngine;
using DG.Tweening;
using Unity.Collections.LowLevel.Unsafe;

public class KnifeController : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public float Number;
    public Rigidbody2D Knife;
    private bool _collision = false;
    private bool _pressed = false;
    private static string _state;
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
        Knife.AddForce(new Vector3(0,Number,0));
    }
    public void CollisionHandler()
    {
        _collision = !_collision;
    }
}
