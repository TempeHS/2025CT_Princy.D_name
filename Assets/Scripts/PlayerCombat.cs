using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    public Transform AP;
    // AP is Attack Point 
    public float attackRange = 0.5f;
    public LayerMask enemyLayers; // LayerMasks are applied in order to define who the enemies are.

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
        }
    }

    void Attack()
    {
        Debug.Log("City");
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AP.position, attackRange, enemyLayers); // Creates a circle from the AP and the attack range value, and returns what the circle interacted with.
        // -- DAMAGE -- 
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
        }
    }
}
