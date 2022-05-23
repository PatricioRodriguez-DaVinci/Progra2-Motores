using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Chaser : MonoBehaviour
{
    NavMeshAgent thisEnemy;
    [SerializeField] private Transform playerTransform;

    private void Start()
    {
        if (playerTransform == null)
        {
            Debug.LogWarning("Se asigna Player Transform a Enemy");

            GameObject gameObj;
            gameObj = GameObject.FindGameObjectWithTag("PlayerBody");
            playerTransform = gameObj.transform;
        }
        thisEnemy = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        thisEnemy.SetDestination(playerTransform.position);
    }
}
