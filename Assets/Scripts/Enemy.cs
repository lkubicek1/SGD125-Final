using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Transform pt;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        pt = GameManager.gm.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = pt.position;
    }
}
