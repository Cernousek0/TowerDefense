using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{   
    [SerializeField]
    private GameObject target;
    NavMeshAgent agent;
    
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }   
    void Start()
    {
        setDestination();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setDestination()
    {
        Vector3 targetPos = target.transform.position;
        agent.SetDestination(targetPos);
    }
}
