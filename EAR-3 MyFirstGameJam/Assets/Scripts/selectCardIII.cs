using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectCardIII : MonoBehaviour
{
    public cardManager manager;
    public Image cardToAdd;
    public Button buttonCard;
    public int maxCardsInACategory;
    public static int currentNumOfCardsInDeck_3;

    public void AddCard()
    {
        Debug.Log(cardToAdd + " added");
        if(currentNumOfCardsInDeck_3 < maxCardsInACategory)
        {
            manager.cardsIII[currentNumOfCardsInDeck_3] = cardToAdd;
            buttonCard.gameObject.SetActive(false);
            currentNumOfCardsInDeck_3++;
        }
        else
        {
            Debug.Log("Too many cards");
        }
    }

     public void RestartCardIII()
    {
        currentNumOfCardsInDeck_3=0;
    }
}
