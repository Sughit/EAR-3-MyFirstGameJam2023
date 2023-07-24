using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    healthBarScript healthBar;

    public float health=100f; 
    public float maxHealth=100f;


    GameObject player;



    public float speed;
    public float range=10f;

    float distance;
    

    public void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


        if (distance < range)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed *Time.deltaTime); 
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }
    

    

    void Awake()
    {
        healthBar = GetComponentInChildren<healthBarScript>();
        player = GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player");
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

        void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "bullet")
         {
            TakeDamage(20);
            Destroy(collision.gameObject);
         }
    }
}
