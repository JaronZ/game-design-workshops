using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private UnityEvent OnArriveAtDestination;
    
    private NavMeshAgent _navMeshAgent;
    private Vector3 lastReachedDestintion = Vector3.positiveInfinity;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        if (Destination != lastReachedDestintion && AtDestination())
        {
            OnArriveAtDestination.Invoke();
        }
    }

    private bool AtDestination()
    {
        float dist = _navMeshAgent.remainingDistance;
        return !float.IsPositiveInfinity(dist) && _navMeshAgent.pathStatus == NavMeshPathStatus.PathComplete && _navMeshAgent.remainingDistance == 0;
    }

    public Vector3 Destination
    {
        get => _navMeshAgent.destination;
        set => _navMeshAgent.destination = value;
    }

    public bool ShouldMove()
    {
        return _navMeshAgent.velocity.magnitude > 0.5f && _navMeshAgent.remainingDistance > _navMeshAgent.radius;
    }
}
