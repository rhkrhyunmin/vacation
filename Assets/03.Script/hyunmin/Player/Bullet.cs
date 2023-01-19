using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    EnemyManager Enemy;
    [Header("거리")]
    public float speed = 15;
    public float time = 0;
    [Header("데미지")]
    public float damage = 3;

    public void Start()
    {
        Enemy = GetComponent<EnemyManager>();
    }

    public void Update()
    {
        DistoryBullet();
        Damage();
    }

    public void DistoryBullet()
    {
        time += Time.deltaTime;
        if (time > 3)
        {
            Destroy(this.gameObject);
        }
        this.transform.Translate(Vector3.left * this.speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Enemy.CurrentHp -= damage;
            Destroy(collision.gameObject);
            if(Enemy.CurrentHp < 0)
            {
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }
        }
    }

    public void Damage()
    {
       
    }

    
}
