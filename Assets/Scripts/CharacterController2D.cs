using System;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField] public float runSpeed = 5f;
    [SerializeField] public float secondSpeed;
    public float jumpForce = 2000f;
    public Rigidbody2D chRigidbody2D;
    public float horizontalMove;
    public float verticalMove;
    public static SpriteRenderer CharacterSpriteRenderer;

    public int numberOfJumps = 0;

    void Start()
    {
        CharacterSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (GameManager.GetState() == "Play")
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
         
            {
                Move(secondSpeed);
            }
            else
            {
                Move(runSpeed);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && GameManager.GetState() == "Start")
        {
            GameManager.ChangeState("Play");
        }

        if(GameManager.GetState() == "Play")
        {
            if (numberOfJumps < 3)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    Jump(jumpForce);
                }
            }
        

            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.LeftShift))
            {
                Jump(-jumpForce); 
            }
            
        }
    }




    void Jump(float realJumpForce)
    {
        numberOfJumps++;
        chRigidbody2D.AddForce(Vector2.up * realJumpForce);
    }

  


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "bar")
        {
            GameManager.ChangeState("Loose");

        }

        if (other.collider.name == "WinBox")
        {
            GameManager.ChangeState("Win");
        }

    }

    private void OnCollisionStay2D(Collision2D other)
    {
        
        if (other.collider.name == "Ground")
        {
            numberOfJumps=0;
            
        }
    }


    void Move(float speed)
    {
        transform.Translate(new Vector3(10 * speed, 0, 0));
    }


}
