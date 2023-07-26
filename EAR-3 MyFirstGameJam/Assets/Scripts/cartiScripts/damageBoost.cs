using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageBoost : MonoBehaviour
{
    public useCardI damageCard;
    private bulletScript bullet;
    public float maxDamageBoost;
    public float boostDuration;
    Movement player;

    void Update()
    {
        if(damageCard.cardUsed)
        {
            StartCoroutine(DamageBoost());
        }
    }

    IEnumerator DamageBoost()
    {
        player = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player").GetComponent<Movement>();

        if(player != null)
        {
            Debug.Log("player found");
        }

        StartCoroutine(DamageEffect());
        yield return null;
    }

    IEnumerator DamageEffect()
    {
        if(bullet.damage != maxDamageBoost)
        {
            bullet.damage += 20;
            yield return new WaitForSeconds(boostDuration);
            Debug.Log("speed effect is gone");
            bullet.damage -= 20;
        }
        else yield return null;
    }
}
