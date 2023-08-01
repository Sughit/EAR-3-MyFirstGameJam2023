using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class immunityCard : MonoBehaviour
{
    public useCardIII immunity;
    public float boostDuration;
    public GameObject particule;

    void Update()
    {
        particule = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player/particule/immunity");
        if(immunity.cardUsed)
        {
            StartCoroutine(ImmunityEffect());
        }
    }

    IEnumerator ImmunityEffect()
    {
        particule.SetActive(true);
        float currentDamage = glontInamic.damage;
        float currentResistenceDamage = glontInamic.resistenceDamage;
        glontInamic.damage = 0;
        glontInamic.resistenceDamage = 0;
        yield return new WaitForSeconds(boostDuration);
        glontInamic.damage = currentDamage;
        glontInamic.resistenceDamage = currentResistenceDamage;
        particule.SetActive(false);
    }
}
