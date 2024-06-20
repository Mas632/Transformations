using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByWaypoints : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private List<Transform> _waypoints;

    private int _currentWaypointIndex = 0;

    private Transform CurrentWaypoint => _waypoints[_currentWaypointIndex];

    private void Update()
    {
        MoveToCurrentWaypoint();

        if (IsWaypointReached())
        {
            ToggleToNextWaypoint();
        }
    }

    private void MoveToCurrentWaypoint()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                 CurrentWaypoint.position,
                                                 _speed * Time.deltaTime);
    }

    private bool IsWaypointReached()
    {
        return transform.position == CurrentWaypoint.position;
    }

    private void ToggleToNextWaypoint()
    {
        if (IsWaypointReached())
        {
            _currentWaypointIndex = (_currentWaypointIndex + 1) % _waypoints.Count;
        }
    }
}
