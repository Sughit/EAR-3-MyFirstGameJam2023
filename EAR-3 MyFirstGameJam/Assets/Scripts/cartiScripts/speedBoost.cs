using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    public useCardI speedCard;
    private Movement player;
    public float maxSpeedBoost;
    public float boostDuration;
    public GameObject particule;

    void Update()
    {
        particule = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player/particule/speed");
        if(speedCard.cardUsed)
        {
            StartCoroutine(SpeedBoost());
        }
    }

    IEnumerator SpeedBoost()
    {
        player = GameObject.Find("GENERARE/SPAWNED/parinte player(Clone)/player").GetComponent<Movement>();

        if(player != null)
        {
            Debug.Log("player found");
        }

        StartCoroutine(SpeedEffect());
        yield return null;
    }

    IEnumerator SpeedEffect()
    {
        particule.SetActive(true);
        if(player.speed != maxSpeedBoost)
        {
            player.speed += 200f;
            yield return new WaitForSeconds(boostDuration);
            Debug.Log("speed effect is gone");
            player.speed -= 200f;
            particule.SetActive(false);
        }
        else yield return null;
    }
}
