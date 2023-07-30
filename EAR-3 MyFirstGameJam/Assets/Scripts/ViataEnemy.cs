using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViataEnemy : MonoBehaviour
{
    healthBarScript healthBar;

    public float health=100f; 
    public static float maxHealth=100f;

    public GameObject particuleFoc;

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

        if(health<=0)
        {
            Destroy(gameObject);
        }
    }

    public void OnFire()
    {
        StartCoroutine(TakeFireDamage());
    }

    IEnumerator TakeFireDamage()
    {
        particuleFoc.SetActive(true);
        for(int i = 0; i < 5; i++)
        {
            TakeDamage(5f);
            yield return new WaitForSeconds(1);
        }
        particuleFoc.SetActive(false);
    }
}
