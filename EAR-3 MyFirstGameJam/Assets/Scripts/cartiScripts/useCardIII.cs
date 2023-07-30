using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useCardIII : MonoBehaviour
{
    public cardManager manager;
    public bool cardUsed;

    void Update()
    {
        if(this.gameObject.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log(this.gameObject + " used");
                StartCoroutine(UseCard());
            }
        }
    }

    IEnumerator UseCard()
    {
        cardUsed = true;
        yield return null;
        Debug.Log("card set false");
        cardUsed = false;
        manager.CycleCardsIII();
        yield return null;
    }
}
