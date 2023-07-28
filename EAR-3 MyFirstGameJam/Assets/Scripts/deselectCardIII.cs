using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deselectCardIII : MonoBehaviour
{
    public cardManager manager;
    public Image cardToRemove;

    public void RemoveCard()
    {
        Debug.Log(cardToRemove + " removed");
        for(int i = 0; i < 3; i++)
        {
            if(manager.cardsIII[i] == cardToRemove)
            {
                manager.cardsIII[i] = null;
                selectCardIII.currentNumOfCardsInDeck_3--;
            }
            else
            {
                Debug.Log("something went wrong");
            }
        }
    }
}
