using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class useCard : MonoBehaviour, IPointerClickHandler
{
    public cardManager manager;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("card did something");

        //dezactivam toate cartile de pe ecran
        foreach (var cardI in manager.cardsI)
        {
            cardI.gameObject.SetActive(false);
        }
        foreach (var cardII in manager.cardsII)
        {
            cardII.gameObject.SetActive(false);
        }
        foreach (var cardIII in manager.cardsIII)
        {
            cardIII.gameObject.SetActive(false);
        }

        //alegem alte carti
        manager.CycleCards();
    }
}
