using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    healthBarScript healthBar;

    public float health=100f; 
    public float maxHealth=100f;

    float speed;
    float range;
    float maxDistance;
    Vector2 wayPoint;

    void NewDestination()
    {
        wayPoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance,maxDistance));
    }


    void Awake()
    {
        healthBar = GetComponentInChildren<healthBarScript>();
    }
    void Start()
    {
        health=maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
        NewDestination();
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
        transform.position = Vector2.MoveTowards(transform.position, wayPoint, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, wayPoint)<range)
        {
            NewDestination();
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
