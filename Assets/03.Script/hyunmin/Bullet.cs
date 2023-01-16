using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;

    void Update()
    {
        Destroy(gameObject);
    }

    public void DistoryBullet()
    {
        if(Time.deltaTime > 10)
        {
            Destroy(this.gameObject);
        }
        this.transform.Translate(Vector3.left * this.speed * Time.deltaTime);
    }
}
