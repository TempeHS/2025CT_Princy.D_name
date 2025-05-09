using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// CLOSE UNITY BEFORE COMMITING.
public class PlayerController : MonoBehaviour
{   
 // The Float variable is used for numbers. 
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;
// The SerializeField references the RigidBody, the Groundcheck and the Groundlayer.
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    // Update is called once per frame
    void Update()
    {
        // Returns a value of 0, -1 or 1 depending on where the player is facing. 
        horizontal = Input.GetAxisRaw("Horizontal");
        
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        // I have no idea what this does, help.
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

     private bool IsGrounded()
     {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
     }


    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
