using UnityEngine;
public class KnifeController : MonoBehaviour
{
    [SerializeField] public float speed;
    private bool _collision = false;
    private bool _pressed = false;
    private static string _state;
    void Update()
    {
        _state = GameManager.GetState();
        if (_state != "Loose")
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
        else
        {
            GameObject ground = GameObject.FindGameObjectWithTag("Ground");
            SpriteRenderer spriteRenderer = ground.transform.GetComponent<SpriteRenderer>();
            spriteRenderer.material.color = Color.red;
            SpriteRenderer knifeRenderer = GetComponent<SpriteRenderer>();
            knifeRenderer.material.color = Color.red;
        }
        
    
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "knife")
        {
            GameManager.ChangeState("Loose");
        } 
    }
    public void CollisionHandler()
    {
        _collision = !_collision;
    }
}
