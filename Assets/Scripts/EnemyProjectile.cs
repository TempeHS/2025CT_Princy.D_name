using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject Projectile;
    public Transform ProjectilePos;
    private float timer;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if (distance < 4)
        {
            timer += Time.deltaTime;  // Timer float will go up in seconds.
        }
        if (timer > 2)
            {
                timer = 0;
                shoot();
            }
    }

    void shoot()
    {
        Instantiate(Projectile, ProjectilePos.position, Quaternion.identity); // Quaternion controls the rotation, which will be controlled in another script. 
    }
}
