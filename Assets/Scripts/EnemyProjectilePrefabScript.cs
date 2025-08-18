using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectilePrefabScript : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position; // Sets a path straight towards the Player.
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
