using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    healthBarScript healthBar;

    public float health=100f; 
    public float maxHealth=100f;

    

    

    void Awake()
    {
        healthBar = GetComponentInChildren<healthBarScript>();
    }
    void Start()
    {
        health=maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    
    public void TakeDamage(float damage)
    {
        health -= damage;
        healthBar.UpdateHealthBar(health, maxHealth);

        if(health==0)
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {

    }
        void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "bullet")
         {
            TakeDamage(20);
            Destroy(collision.gameObject);
         }
    }
}
