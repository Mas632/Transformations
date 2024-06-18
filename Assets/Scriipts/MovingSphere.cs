using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSphere : TransformationObject
{
    [SerializeField] private List<Transform> _waypoints;

    private int _currentWaypointIndex = 0;

    private Transform CurrentWaypoint => _waypoints[_currentWaypointIndex];

    private void Update()
    {
        Move();

        if (IsWaypointReached())
        {
            ToggleToNextWaypoint();
        }
    }

    protected new void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                 CurrentWaypoint.position,
                                                 _moveSpeed * Time.deltaTime);
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
