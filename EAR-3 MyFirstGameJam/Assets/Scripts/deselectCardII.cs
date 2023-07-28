using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deselectCardII : MonoBehaviour
{
    public cardManager manager;
    public Image cardToRemove;

    public void RemoveCard()
    {
        Debug.Log(cardToRemove + " removed");
        for(int i = 0; i < 3; i++)
        {
            if(manager.cardsII[i] == cardToRemove)
            {
                manager.cardsII[i] = null;
                selectCardII.currentNumOfCardsInDeck_2 = i;
            }
            else
            {
                Debug.Log("something went wrong");
            }
        }
    }
}
