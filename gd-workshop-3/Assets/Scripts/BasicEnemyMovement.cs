using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemyController))]
public class BasicEnemyMovement : MonoBehaviour
{
    [SerializeField] private List<Transform> destinations = new();
    
    private EnemyController _controller;
    private int currentDestination;

    private void Awake()
    {
        _controller = GetComponent<EnemyController>();
    }

    private void Start()
    {
        _controller.Destination = destinations[currentDestination].position;
    }

    public void NextDestination()
    {
        currentDestination++;
        if (currentDestination >= destinations.Count)
            currentDestination = 0;
    }
}
