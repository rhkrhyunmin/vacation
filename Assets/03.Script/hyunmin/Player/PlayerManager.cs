using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Vector2 vector3;
    public Rigidbody2D rigidbody2D;

    [Header("스피드")]
    public float speed = 10;
    [Header("점프")]
    public float jumpSpeed = 15;
    public bool isJumping;
    [Header("대쉬")]
    public float isDash = 10;
    public bool isDashing;
    [Header("총")]
    public GameObject bullet;
    public Transform bulletSpawnpoint;
    //public Transform Target;

    public void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        bulletSpawnpoint = this.transform.Find("BulletSpawnPoint");
    }

    public void Update()
    {
        Move();
        Jump();
        Attack();
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

    public void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bulletGO = Instantiate<GameObject>(this.bullet);
            bulletGO.transform.position = this.bulletSpawnpoint.position;
            Debug.Log("ㅄ");
        }
    }
}
