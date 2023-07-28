using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunetCarti : MonoBehaviour
{

    AudioSource cartiSunet;
    
    
    public void SunetI()
    {
        if(selectCardI.currentNumOfCardsInDeck_1<3)
        {
            cartiSunet = GetComponent<AudioSource>();
            cartiSunet.Play(0);
        }
    }

    public void SunetII()
    {
        if(selectCardII.currentNumOfCardsInDeck_2<3)
        {
            cartiSunet = GetComponent<AudioSource>();
            cartiSunet.Play(0);
        }
    }

    public void SunetIII()
    {
        if(selectCardIII.currentNumOfCardsInDeck_3<3)
        {
            cartiSunet = GetComponent<AudioSource>();
            cartiSunet.Play(0);
        }
    }

    
}
