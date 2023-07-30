using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verifyNumOfCardsSelected : MonoBehaviour
{
    public Text cardsIText;
    public Text cardsIIText;
    public Text cardsIIIText;

    public GameObject panou;
    public CursorManager cursor;
    public cardManager manager;

    void Update()
    {
        cardsIText.text = selectCardI.currentNumOfCardsInDeck_1.ToString() + "/3";
        cardsIIText.text = selectCardII.currentNumOfCardsInDeck_2.ToString() + "/3";
        cardsIIIText.text = selectCardIII.currentNumOfCardsInDeck_3.ToString() + "/3";
    }

    public void Verify()
    {
        //nu vreau sa creez un nou script pentru asta
        manager.cardsI[cardManager.cardsIindex].gameObject.SetActive(true);
        manager.cardsII[cardManager.cardsIIindex].gameObject.SetActive(true);
        manager.cardsIII[cardManager.cardsIIIindex].gameObject.SetActive(true);

        if(selectCardI.currentNumOfCardsInDeck_1 == 3 &&
           selectCardII.currentNumOfCardsInDeck_2 == 3 &&
           selectCardIII.currentNumOfCardsInDeck_3 == 3)
        {
            panou.SetActive(false);
            cursor.SaInceapaAventura();
            manager.CycleCards();
        }
        else
        {
            Debug.Log("select more cards");
        }
    }
}
