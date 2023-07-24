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

    void Start()
    {
        Debug.Log("carti alese");
        cardsI[Random.Range(0, cardsI.Length)].gameObject.SetActive(true);
        cardsII[Random.Range(0, cardsII.Length)].gameObject.SetActive(true);
        cardsIII[Random.Range(0, cardsIII.Length)].gameObject.SetActive(true);
        
        
    }

    public void CycleCards()
    {
        //alege 3 carti aleatorii in functie de lista
        cardsI[Random.Range(0, cardsI.Length)].gameObject.SetActive(true);
        cardsII[Random.Range(0, cardsII.Length)].gameObject.SetActive(true);
        cardsIII[Random.Range(0, cardsIII.Length)].gameObject.SetActive(true);
    }
}
