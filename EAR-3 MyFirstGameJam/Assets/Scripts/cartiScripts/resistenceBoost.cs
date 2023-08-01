using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resistenceBoost : MonoBehaviour
{
    public useCardI resistenceCard;
    public bool isBoost;
    public float boostDuration;
    public GameObject particule;

    void Update()
    {
        particule = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player/particule/resistence");
        if(resistenceCard.cardUsed)
        {
            StartCoroutine(IncreaseResistence());
        }
    }

    IEnumerator IncreaseResistence()
    {
        particule.SetActive(true);
        isBoost = true;
        yield return new WaitForSeconds(boostDuration);
        isBoost = false;
        particule.SetActive(false);
        yield return null;
    }
}
