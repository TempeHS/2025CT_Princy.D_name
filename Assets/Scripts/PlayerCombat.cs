using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
    public Transform attackPoint; // AP is Attack Point 
    public LayerMask enemyLayers; // LayerMasks are applied in order to define who the enemies are.
    public float attackRange = 0.5f;
    public int AttackDamage = 40;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Attack();
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
    
    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange); // Draws a sphere in the editor around the AP and attack range? 
    }
}
