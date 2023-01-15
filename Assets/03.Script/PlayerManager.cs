using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Vector2 vector3;
    public Rigidbody2D rigidbody2D;
    public bool isJumping;
    public bool isDashing;
    public float speed = 10;
    public float jumpSpeed = 5;
    public float isDash = 10;

    public void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        
    }

    public void Update()
    {
        Move();
        Jump();
    }

    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        vector3 = new Vector2(x,0);
        transform.position += (Vector3) (vector3 * speed * Time.deltaTime);
    }

    public void Jump()
    {
        if (Input.GetKey(KeyCode.Space)&& isJumping == false)
        {
            rigidbody2D.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    public void Dash()
    {
        if(Input.GetKey(KeyCode.X)&& isDashing == false)
        {
            rigidbody2D.AddForce(Vector3.left * isDash, ForceMode2D.Force);
            //rigidbody2D.AddForce(Vector3.right * isDash, ForceMode2D.Force);
            isDashing = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping=false;
        }
    }
}
