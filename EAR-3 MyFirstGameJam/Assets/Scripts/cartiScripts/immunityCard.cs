using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class immunityCard : MonoBehaviour
{
    public useCardIII immunity;
    public float boostDuration;

    void Update()
    {
        if(immunity.cardUsed)
        {
            StartCoroutine(ImmunityEffect());
        }
    }

    IEnumerator ImmunityEffect()
    {
        float currentDamage = glontInamic.damage;
        float currentResistenceDamage = glontInamic.resistenceDamage;
        glontInamic.damage = 0;
        glontInamic.resistenceDamage = 0;
        yield return new WaitForSeconds(boostDuration);
        glontInamic.damage = currentDamage;
        glontInamic.resistenceDamage = currentResistenceDamage;
    }
}
