using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleStatsCard : MonoBehaviour
{
    public useCardIII doubleStats;
    public float boostDuration;

    public speedBoost speed;
    public healthBoost health;

    void Update()
    {
        if(doubleStats.cardUsed)
        {
            StartCoroutine(DoubleStats());
        }
    }

    IEnumerator DoubleStats()
    {
        speed.boostDuration = 20f;
        health.healAmount = 40f;
        bulletScript.damageBoost = 80;
        glontInamic.resistenceDamage = 3f;
        yield return new WaitForSeconds(boostDuration);
        speed.boostDuration = 10f;
        health.healAmount = 20f;
        bulletScript.damageBoost = 40;
        glontInamic.resistenceDamage = 7f;
    }
}
