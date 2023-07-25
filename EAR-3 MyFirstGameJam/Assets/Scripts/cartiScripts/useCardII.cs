using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useCardII : MonoBehaviour
{
    public cardManager manager;
    public bool cardUsed;

    void Update()
    {
        if(this.gameObject.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Alpha2))
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
        manager.CycleCards();
        yield return null;
    }
}
