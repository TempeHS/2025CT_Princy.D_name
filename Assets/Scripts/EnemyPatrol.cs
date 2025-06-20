using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public GameObject PointA; // Referencing Point A.
    public GameObject PointB; // Referencing Point B.
    private Rigidbody2D rb; // Referencing RigidBody2D. Private will mean that it cannot be edited. 
    private Transform currentPoint;
    public float speed;
    public int damage;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = PointB.transform; // The current point is set as PointB.
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 point = currentPoint.position - transform.position; // Gives a direction that the enemy should go towards. Will be current point.
        if (currentPoint == PointB.transform) // If the current point is B (WHICH IT IS.)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointB.transform) // Line compares the distance between the player and the current point, which is specified as PointB.
        {
            currentPoint = PointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == PointA.transform) // Line compares the distance between the player and the current point, which is specified as PointB.
        {
            currentPoint = PointB.transform;
        }
    }
}
