using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectilePrefabScript : MonoBehaviour
{

    private GameObject player;
    private Rigidbody2D rb;
    public float force;
    private float timer;
    public int damage;
    public PlayerController playerHealth;

            void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage);
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position; // Sets a projectile path straight towards the Player.
        rb.velocity = new Vector2(direction.x, direction.y).normalized * force; // Control the speed of the projectile.

        float rotation = Mathf.Atan(-direction.y - direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotation + 90);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 10)
        {
            Destroy(gameObject);
        }
    }
            void OnTriggerEnter2D(Collider2D other)
        {
        if (other.gameObject.CompareTag("Player"))
        {
                Destroy(gameObject);
                playerHealth.TakeDamage(damage);
            }
        }
}
