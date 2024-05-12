using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    
    [SerializeField]
    private Transform targetPosition;

    private NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start() {
        
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()  {
        
    navMeshAgent.destination = targetPosition.position;

    }
}
