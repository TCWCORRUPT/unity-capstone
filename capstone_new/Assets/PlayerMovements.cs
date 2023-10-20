using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    //int wholeNumber = 16;
    //float decimalNumber = 4.56f;

    // Start is called before the first frame update
    private void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity=new Vector2 (dirx*7f,rb.velocity.y);

        if (Input.GetButtonDown("Jump") || Input.GetKey("w"))
        {
            rb.velocity = new Vector3(rb.velocity.x, 6);
        }
 
    }
}
