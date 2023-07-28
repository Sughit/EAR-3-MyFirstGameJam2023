using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectCardI : MonoBehaviour
{
    public cardManager manager;
    public Image cardToAdd;
    public Button buttonCard;
    public int maxCardsInACategory;
    public static int currentNumOfCardsInDeck_1;

    public void AddCard()
    {
        Debug.Log(cardToAdd + " added");
        if(currentNumOfCardsInDeck_1 < maxCardsInACategory)
        {
            manager.cardsI[currentNumOfCardsInDeck_1] = cardToAdd;
            buttonCard.gameObject.SetActive(false);
            currentNumOfCardsInDeck_1++;
        }
        else
        {
            Debug.Log("Too many cards");
        }
    }

    public void RestartCardI()
    {
        currentNumOfCardsInDeck_1=0;
    }
}
