using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBoost : MonoBehaviour
{
    public useCardI healthCard;
    private ViataPlayer player;

    void Update()
    {
        if(healthCard.cardUsed)
        {
            StartCoroutine(HealthBoost());
        }
    }

    IEnumerator HealthBoost()
    {
        player = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player").GetComponent<ViataPlayer>();

        if(player != null)
        {
            Debug.Log("player found");
        }

        if(player.health <= 80)
        {
            player.health += 20f;
        }
        else
        {
            player.health = player.maxHealth;
        }
        yield return null;
    }
}
