using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViataPlayer : MonoBehaviour
{
    public Slider slider;
    public float health=100f; 
    public float maxHealth=100f;
    private Movement miscare;
    public GameObject moarte;
    public Text textViata;

    void Start()
    {
        UpdateHealthBarPlayer(health, maxHealth);
        health=maxHealth;
        miscare=GetComponent<Movement>();
    }


    void Update()
    {
        if(health<=0)
        {
            Die();
        }
        textViata.text = health.ToString();
    }
    public void Die()
    {
        miscare.enabled=!miscare.enabled;
        Destroy(gameObject);
        Instantiate(moarte, transform.position, transform.rotation);

    }

    public void UpdateHealthBarPlayer(float ValoareCurenta, float ValoareMaxima)
    {
        slider.value = (ValoareCurenta / ValoareMaxima)*100;
    }

    public void NuMaiDaCaMaDoare(float damageLuat)
    {
        health -= damageLuat;
        UpdateHealthBarPlayer(health, maxHealth);
    }
}
