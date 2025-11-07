using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint; // AP is Attack Point 
    public LayerMask enemyLayers; // LayerMasks are applied in order to define who the enemies are.
    public float attackRange = 0.5f;
    public int AttackDamage = 100000;

    public float AttackRate = 2f;
    float nextAttackTime = 0f;
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Attack();
                nextAttackTime = Time.time + 1f / AttackRate;
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); // Creates a circle from the AP and the attack range value, and returns what the circle interacted with.
        // -- DAMAGE -- 
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(AttackDamage);
        }
    }
    
    // Second script test
    

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange); // Draws a sphere in the editor around the AP and attack range.
    }
}
