using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSettings : MonoBehaviour
{
    public PlayerMovements playerDirection;
    public float Bullet_Speed = 0.1f;
    public float durationTaken = 0;
    public int bulletDuration = 0;
    private bool goRight;
    // Start is called before the first frame update
    void Start()
    {
        playerDirection = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovements>();
        goRight = playerDirection.facingRight;
        Debug.Log(goRight.ToString());
    }
    
    // Update is called once per frame
    void Update()
    {
        if (goRight)
        {
			transform.Translate(transform.right * Bullet_Speed * Time.deltaTime);
		} else
        {
            transform.Translate(transform.right * -1 * Bullet_Speed * Time.deltaTime);
        }
        
        durationTaken += Time.deltaTime;
        if (durationTaken > bulletDuration)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(10);
            Destroy(gameObject);
        }
    }

}
