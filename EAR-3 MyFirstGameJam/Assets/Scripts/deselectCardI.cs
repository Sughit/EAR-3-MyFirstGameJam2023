using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deselectCardI : MonoBehaviour
{
    public cardManager manager;
    public Image cardToRemove;

    public void RemoveCard()
    {
        Debug.Log(cardToRemove + " removed");
        for(int i = 0; i < 3; i++)
        {
            if(manager.cardsI[i] == cardToRemove)
            {
                manager.cardsI[i] = null;
                selectCardI.currentNumOfCardsInDeck_1--;
            }
            else
            {
                Debug.Log("something went wrong");
            }
        }
    }
}
