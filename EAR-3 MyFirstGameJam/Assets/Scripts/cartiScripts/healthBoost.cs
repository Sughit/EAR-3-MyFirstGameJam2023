using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBoost : MonoBehaviour
{
    public useCardI healthCard;
    private ViataPlayer player;
    public float healAmount;
    public GameObject particule;

    void Update()
    {
        particule = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player/particule/heal");
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
            player.NuMaiDaCaMaDoare(-healAmount);
            particule.SetActive(true);
        }
        else
        {
            particule.SetActive(true);
            player.health=100;
            player.UpdateHealthBarPlayer(player.health, player.maxHealth);
        }
        yield return new WaitForSeconds(1f);
        particule.SetActive(false);
        yield return null;
    }
}
