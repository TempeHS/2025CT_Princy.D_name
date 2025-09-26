using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100;
    int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 100; 
    }

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;
        
        if (currentHealth <= 0)
        {
            Death();
        }
    }


    void Death()
    {
        Debug.Log("Enemy is dead.");
        Destroy(gameObject);
    }
}
