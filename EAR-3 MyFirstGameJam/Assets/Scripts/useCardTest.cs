using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class useCardTest : MonoBehaviour, IPointerClickHandler
{
    public cardManager manager;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("cartea a facut ceva");

        manager.CycleCards();
    }
}
