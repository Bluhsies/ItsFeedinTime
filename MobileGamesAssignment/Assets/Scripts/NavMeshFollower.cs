using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshFollower : MonoBehaviour
{

    public GameObject player;

    private Transform waypoints;

    private NavMeshAgent agent;



    void Start()
    {
        player = GameObject.FindWithTag("Player");
        waypoints = player.transform;

        agent = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {

        agent.destination = waypoints.position;
        

    }
}
