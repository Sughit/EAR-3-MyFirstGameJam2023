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

     void Start()
     {
         Debug.Log("carti alese");
         cardSelector.SetActive(true);
         cardsI[Random.Range(0, cardsI.Length)].gameObject.SetActive(true);
         cardsII[Random.Range(0, cardsII.Length)].gameObject.SetActive(true);
         cardsIII[Random.Range(0, cardsIII.Length)].gameObject.SetActive(true);
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
    }

    /*public void PentruRestart()
    {
         for(int i=0;i<3;i++)
         {
            cardsI[i]=null;
         }
         for(int i=0;i<3;i++)
         {
            cardsII[i]=null;
         }
         for(int i=0;i<3;i++)
         {
            cardsIII[i]=null;
         }

    }*/
}
