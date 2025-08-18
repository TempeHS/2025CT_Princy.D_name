using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public GameObject Projectile;
    public Transform ProjectilePos;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;  // Timer float will go up in seconds.

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
