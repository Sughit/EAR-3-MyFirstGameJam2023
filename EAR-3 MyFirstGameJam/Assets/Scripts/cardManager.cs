using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;

public class cardManager : MonoBehaviour
{
    public Image[] cardsI;
    public Image[] cardsII;
    public Image[] cardsIII;
    public GameObject cardSelector;

    public static int cardsIindex = 0;
    public static int cardsIIindex = 0;
    public static int cardsIIIindex = 0;

     void Start()
     {
        Debug.Log("carti alese");
        cardSelector.SetActive(true);
        
        //  cardsI[Random.Range(0, cardsI.Length)].gameObject.SetActive(true);
        //  cardsII[Random.Range(0, cardsII.Length)].gameObject.SetActive(true);
        //  cardsIII[Random.Range(0, cardsIII.Length)].gameObject.SetActive(true);
     }

    public void CycleCards()
    {
        //dezactiveaza toate cartile de pe ecran
        foreach (var cardI in cardsI)
        {
            cardI.gameObject.SetActive(false);
        }
        foreach (var cardII in cardsII)
        {
            cardII.gameObject.SetActive(false);
        }
        foreach (var cardIII in cardsIII)
        {
            cardIII.gameObject.SetActive(false);
        }

        //alege 3 carti aleatorii in functie de lista
        cardsI[Random.Range(0, cardsI.Length)].gameObject.SetActive(true);
        cardsII[Random.Range(0, cardsII.Length)].gameObject.SetActive(true);
        cardsIII[Random.Range(0, cardsIII.Length)].gameObject.SetActive(true);
    }

    public void CycleCardsI()
    {
        cardsI[cardsIindex].gameObject.SetActive(false);
        if(cardsIindex != 2)
        {
            cardsIindex++;
            cardsI[cardsIindex].gameObject.SetActive(true);
            
        }
        else
        {
            cardsI[0].gameObject.SetActive(true);
            cardsIindex = 0;
        }
    }

    public void CycleCardsII()
    {
        cardsII[cardsIIindex].gameObject.SetActive(false);
        if(cardsIIindex != 2)
        {
            cardsIIindex++;
            cardsII[cardsIIindex].gameObject.SetActive(true);
            
        }
        else
        {
            cardsII[0].gameObject.SetActive(true);
            cardsIIindex = 0;
        }
    }

    public void CycleCardsIII()
    {
        cardsIII[cardsIIIindex].gameObject.SetActive(false);
        if(cardsIIIindex != 2)
        {
            cardsIIIindex++;
            cardsIII[cardsIIIindex].gameObject.SetActive(true);
            
        }
        else
        {
            cardsIII[0].gameObject.SetActive(true);
            cardsIIIindex = 0;
        }
    }

    void Update()
    {
        if(cardsI[0] == null)
        {
            cardsI[0] = cardsI[1];
            cardsI[1] = cardsI[2];
            cardsI[2] = null;
        }else if(cardsI[1] == null)
        {
            cardsI[1] = cardsI[2];
            cardsI[2] = null;
        }

        if(cardsII[0] == null)
        {
            cardsII[0] = cardsII[1];
            cardsII[1] = cardsII[2];
            cardsII[2] = null;
        }else if(cardsII[1] == null)
        {
            cardsII[1] = cardsII[2];
            cardsII[2] = null;
        }

        if(cardsIII[0] == null)
        {
            cardsIII[0] = cardsIII[1];
            cardsIII[1] = cardsIII[2];
            cardsIII[2] = null;
        }else if(cardsIII[1] == null)
        {
            cardsIII[1] = cardsIII[2];
            cardsIII[2] = null;
        }
        
        foreach (var cardI in cardsI)
        {
            if(cardI.gameObject.activeSelf == true && cardI != cardsI[cardsIindex])
            {
                cardI.gameObject.SetActive(false);
                cardsI[cardsIindex].gameObject.SetActive(true);
            }
        }
        foreach (var cardII in cardsII)
        {
            if(cardII.gameObject.activeSelf == true && cardII != cardsII[cardsIIindex])
            {
                cardII.gameObject.SetActive(false);
                cardsII[cardsIIindex].gameObject.SetActive(true);
            }
        }
        foreach (var cardIII in cardsIII)
        {
            if(cardIII.gameObject.activeSelf == true && cardIII != cardsIII[cardsIIIindex])
            {
                cardIII.gameObject.SetActive(false);
                cardsIII[cardsIIIindex].gameObject.SetActive(true);
            }
        }
    }
}
