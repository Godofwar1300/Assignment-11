﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    private NavMeshAgent thisAgent = null;
    public Transform player = null;

    void Awake()
    {
        thisAgent = GetComponent<NavMeshAgent>();
       // player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        thisAgent.SetDestination(player.position);
    }
}
