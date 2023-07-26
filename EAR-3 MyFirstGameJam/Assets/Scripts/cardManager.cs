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
}
