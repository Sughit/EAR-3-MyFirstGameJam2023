using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageBoost : MonoBehaviour
{
    public useCardI damageCard;
    public bool isBoost;
    public float boostDuration;
    public GameObject particule;

    void Update()
    {
        particule = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player/particule/damage");
        if(damageCard.cardUsed)
        {
            StartCoroutine(IncreaseDamage());
        }
    }

    IEnumerator IncreaseDamage()
    {
        particule.SetActive(true);
        isBoost = true;
        yield return new WaitForSeconds(boostDuration);
        isBoost = false;
        particule.SetActive(false);
        yield return null;
    }
}
