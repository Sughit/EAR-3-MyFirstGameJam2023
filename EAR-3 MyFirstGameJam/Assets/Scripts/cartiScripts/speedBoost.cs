using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    public useCardI speedCard;
    private Movement player;
    public float maxSpeedBoost;
    public float boostDuration;

    void Update()
    {
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
        if(player.speed != maxSpeedBoost)
        {
            player.speed += 200f;
            yield return new WaitForSeconds(boostDuration);
            Debug.Log("speed effect is gone");
            player.speed -= 200f;
        }
        else yield return null;
    }
}
