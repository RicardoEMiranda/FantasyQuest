using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour {
    
    [SerializeField]
    private Transform targetPosition;

    private NavMeshAgent navMeshAgent;

    Ray ray;

    // Start is called before the first frame update
    void Start() {
        
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()  {
        
        if(Input.GetMouseButtonDown(0)) {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }

        Debug.DrawRay(ray.origin, ray.direction*100);
        navMeshAgent.destination = targetPosition.position;

    }
}
