using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    private NavMeshAgent character;
    private Transform target;

    void Start()
    {
        character = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Target").transform;
    }

    void Update()
    {
        character.SetDestination(target.position);
    }
}
