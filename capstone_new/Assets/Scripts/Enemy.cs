using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public static event Action<Enemy> onEnemyKilled;
    [SerializeField] float health, maxHealth = 30f;
    Rigidbody2D rb;
    [SerializeField] HealthEnemy healthbar;
    [SerializeField] HealthManager healthManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        healthbar=GetComponentInChildren<HealthEnemy>();
    }

    private void Start()
    {
        health = maxHealth;
        healthbar.UpdateHealthBar(health, maxHealth);
    }

    public void TakeDamage(float dmageAmount)
    {
        health-=dmageAmount;
        healthbar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
            Die();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<HealthManager>(out HealthManager player))
        {
            player.TakeDamaege(10);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
