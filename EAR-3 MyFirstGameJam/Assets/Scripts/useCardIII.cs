using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useCardIII : MonoBehaviour
{
    public cardManager manager;

    void Update()
    {
        if(this.gameObject.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                Debug.Log(this.gameObject + " used");
                manager.CycleCards();
            }
        }
    }
}
