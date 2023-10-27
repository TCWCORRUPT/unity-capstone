using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovements : MonoBehaviour
{
    public float movespeed;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private float dirx;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //private void Start()
    //{
        
    //}

    // Update is called once per frame
    private void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity=new Vector2 (dirx*7f,rb.velocity.y);

        if (dirx > 0 && !facingRight)
        {
            flipCharacter();
        }
        else if (dirx < 0 && facingRight)
        {
            flipCharacter();
        }

        if (Input.GetButtonDown("Jump") || Input.GetKey("w"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 6);
        }

    
    }

    private void flipCharacter()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

}
