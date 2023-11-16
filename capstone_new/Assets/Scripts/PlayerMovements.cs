using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovements : MonoBehaviour
{
    public float movespeed;
    public float jumpForce;
    public Transform ceilingCheck;
    public Transform groundCheck;
    public LayerMask groundObject;
    public float checkRadius;
    public int maxJumpCount;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isJumping = false;
    private float dirx;
    private bool isGround;
    private int jumpCount;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        jumpCount = maxJumpCount;
    }

    // Update is called once per frame
    private void Update()
    {
        inputProcesses();

        animate(); //  flip character

    }

    private void FixedUpdate()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObject);
        if(isGround )
        {
            jumpCount = maxJumpCount;
        }
        movement();
    }

    private void movement()
    {
        rb.velocity = new Vector2(dirx * movespeed, rb.velocity.y);
        if (isJumping) // Check if the player is on the ground before allowing a jump
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
        }
        isJumping = false;
    }

    private void inputProcesses()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump")&& jumpCount > 0)
        {
            isJumping = true;
        }
    }

    private void animate()
    {
        if (dirx > 0 && !facingRight)
        {
            flipCharacter();
        }
        else if (dirx < 0 && facingRight)
        {
            flipCharacter();
        }
    }

    private void flipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

}
