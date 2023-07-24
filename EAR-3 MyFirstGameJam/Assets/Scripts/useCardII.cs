using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useCardII : MonoBehaviour
{
    public cardManager manager;

    void Update()
    {
        if(this.gameObject.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                Debug.Log(this.gameObject + " used");
                manager.CycleCards();
            }
        }
    }
}
