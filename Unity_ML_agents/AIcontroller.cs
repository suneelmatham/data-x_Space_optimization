﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIcontroller : MonoBehaviour
{
    
	public GameObject goal;
	NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    { 
    	agent = this.GetComponent<NavMeshAgent>();
    	agent.SetDestination(goal.transform.position);
        
    }
}
