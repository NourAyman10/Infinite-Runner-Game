using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform playerTransform;
    private NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.isGameStarted)
        {
            Vector3 targetVector = playerTransform.transform.position;
            nav.SetDestination(targetVector);
        }
        //nav.destination = playerTransform.position;
    }
}
