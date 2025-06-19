using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// CLOSE UNITY BEFORE COMMITING.
public class PlayerController : MonoBehaviour
{
    // The Float variable is used for a variable. 
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 18f;
    private bool isFacingRight = true;
    private int count;
    public TextMeshProUGUI countText;
    private bool canDash = true;
    private bool isDashing;
    private float dashingPower = 24f;
    private float dashingTime = 0.2f;
    private float dashingCooldown = 1f;
    public int maxHealth = 4;
    public int currentHealth;

    // The SerializeField references the RigidBody, the Groundcheck and the Groundlayer.
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private TrailRenderer tr;
    AudioManager audioManager;
// Private Void Awake allows me to access it and other components.
    private void Awake() 
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Update is called once per frame
    void Start()
    {
        count = 0;
        SetCountText();
        currentHealth = maxHealth;
        
    }
    void Update()
    {
        if (isDashing)
        {
            return;
        }
        // Returns a value of 0, -1 or 1 depending on where the player is facing. 
            horizontal = Input.GetAxisRaw("Horizontal");
/*
        if (Input.GetButtonDown("Jump")) // DELETE THIS.
        {
            TakeDamage(1);
        }
*/
        if (currentHealth == 0)
        {
            Destroy(gameObject);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded()) // Jump Function
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
            }

        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash) // Dash Function
        {
            StartCoroutine(Dash()); // Starts the function at the bottom of the code
        }

        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f) // Jump function.
            {
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f); 
            }

        Flip();
    }

    private void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
        // I have no idea what this does, help.
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
        if (other.gameObject.CompareTag("Enemy"))
        {           
            Destroy(other.gameObject);
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
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
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        audioManager.PlaySFX(audioManager.dash);
        // Make sure to edit the audio later.
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
}
