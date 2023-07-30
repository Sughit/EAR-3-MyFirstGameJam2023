using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class useCardII : MonoBehaviour
{
    public cardManager manager;
    public bool cardUsed;
    static float maxTime = 4f;
    static float currentTime;
    public Image cooldown;

    void Update()
    {
        if(this.gameObject.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Alpha2) && currentTime <= 0)
            {
                Debug.Log(this.gameObject + " used");
                StartCoroutine(UseCard());
                currentTime = maxTime;
                cooldown.gameObject.SetActive(true);
            }
            else
            {
                currentTime -= Time.deltaTime;
            }
        }
        
        //reseteaza cooldown-ul ca imagine
        if(currentTime <= 0)
            cooldown.gameObject.SetActive(false);
    }

    IEnumerator UseCard()
    {
        cardUsed = true;
        yield return null;
        Debug.Log("card set false");
        cardUsed = false;
        manager.CycleCardsII();
        yield return null;
    }
}
