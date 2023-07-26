using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectCardII : MonoBehaviour
{
    public cardManager manager;
    public Image cardToAdd;
    public int maxCardsInACategory;
    static int currentNumOfCardsInDeck_2;

    public void AddCard()
    {
        Debug.Log(cardToAdd + " added");
        if(currentNumOfCardsInDeck_2 < maxCardsInACategory)
        {
            manager.cardsII[currentNumOfCardsInDeck_2] = cardToAdd;
            currentNumOfCardsInDeck_2++;
        }
        else
        {
            Debug.Log("Too many cards");
        }
    }

     public void RestartCardII()
    {
        currentNumOfCardsInDeck_2=0;
    }
}
