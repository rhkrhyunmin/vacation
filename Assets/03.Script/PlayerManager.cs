using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Vector2 vector2;
    public Rigidbody2D rigidbody2D;
    public float speed = 10;

    public void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        Move();
    }

    public void Move()
    {
        float x = vector2.
    }
}
