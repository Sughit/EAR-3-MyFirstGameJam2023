using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViataPlayer : MonoBehaviour
{
    public Slider slider;
    public float health=100f; 
    public float maxHealth=100f;


    void Start()
    {
        UpdateHealthBarPlayer(health, maxHealth);
        health=maxHealth;
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            NuMaiDaCaMaDoare(20f);
        }
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
