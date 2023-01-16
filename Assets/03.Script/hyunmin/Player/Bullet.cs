using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 15;
    public float time = 0;

    void Update()
    {
        DistoryBullet();
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
}
