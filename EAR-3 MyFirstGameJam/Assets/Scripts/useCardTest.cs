using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useCardTest : MonoBehaviour
{
    public cardManager manager;

    public void OnMouseDown()
    {
        Debug.Log("cartea a facut ceva");
        
        manager.CycleCards();
        //dezactiveaza toate cartile de pe ecran
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
    }
}
