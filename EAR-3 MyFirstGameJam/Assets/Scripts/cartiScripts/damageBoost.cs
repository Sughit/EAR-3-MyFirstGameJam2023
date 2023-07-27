using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageBoost : MonoBehaviour
{
    public useCardI damageCard;
    public bool isBoost;
    public float boostDuration;

    void Update()
    {
        
        if(damageCard.cardUsed)
        {
            StartCoroutine(IncreaseDamage());
        }
    }

    IEnumerator IncreaseDamage()
    {
        isBoost = true;
        yield return new WaitForSeconds(boostDuration);
        isBoost = false;
        yield return null;
    }
}
