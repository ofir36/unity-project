using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointScript : MonoBehaviour
{
    public Transform[] waypoint;
    public float speed = 5;
    int currentWayPoint;
    Vector3 target, moveDirection;

    void Update()
    {
        target = waypoint[currentWayPoint].position;
        moveDirection = target - transform.position;

        if (moveDirection.magnitude < 1)
        {
            currentWayPoint = ++currentWayPoint % waypoint.Length;
        }
        Vector3 relativePos = target - transform.position;
        // the second argument, upwards, defaults to Vector3.up
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
        GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;
    }
}
