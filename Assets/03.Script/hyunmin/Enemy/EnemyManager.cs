using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public float speed = 5;
    [Header("À§Ä¡")]
    private Transform target;
    private NavMeshAgent navMesh;

    public void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navMesh = GetComponent<NavMeshAgent>();
    }

    public void Update()
    {
        navMesh.SetDestination(target.position);
    }
}
