using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doubleProjectilesCard : MonoBehaviour
{
    public useCardIII doubleProjectiles;
    public float boostDuration;
    public static bool doubleSmoke;
    
    void Update()
    {
        if(doubleProjectiles.cardUsed)
        {
            StartCoroutine(DoubleProjectiles());
        }
    }

    IEnumerator DoubleProjectiles()
    {
        grenadeExplode.damage = 80f;
        flashExplode.flashedTime = 6f;
        doubleSmoke = true;
        ViataEnemy.fireDamage = 16f;
        yield return new WaitForSeconds(boostDuration);
        grenadeExplode.damage = 40f;
        flashExplode.flashedTime = 3f;
        doubleSmoke = false;
        ViataEnemy.fireDamage = 8f;
    }
}
