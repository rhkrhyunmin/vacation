using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public float speed = 5;
    [Header("위치")]
    private Transform target;
    private NavMeshAgent navMesh;
    [Header("체력")]
    public float CurrentHp;
    public float MaxHp = 10;

    public void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navMesh = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        navMesh.SetDestination(target.position);
        PlayerFind();
    }

    public void PlayerFind()
    {
        float dis = Vector3.Distance(transform.position ,target.position);
        if (dis <= 5)
        {
            Move();
        }
        else return;
    }

    public void Move()
    {
        float dir = target.position.x - transform.position.x;
        dir = (dir < 0) ? -1 : 1;
        transform.position = new Vector2(dir, 0) * speed * Time.deltaTime;
    }
}
