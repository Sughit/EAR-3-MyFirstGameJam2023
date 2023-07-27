using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resistenceBoost : MonoBehaviour
{
    public useCardI resistenceCard;
    public bool isBoost;
    public float boostDuration;

    void Update()
    {
        
        if(resistenceCard.cardUsed)
        {
            StartCoroutine(IncreaseResistence());
        }
    }

    IEnumerator IncreaseResistence()
    {
        isBoost = true;
        yield return new WaitForSeconds(boostDuration);
        isBoost = false;
        yield return null;
    }
}
