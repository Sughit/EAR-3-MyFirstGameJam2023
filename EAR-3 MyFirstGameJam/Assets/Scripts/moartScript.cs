using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moartScript : MonoBehaviour
{
    
    public GameObject meniuMoarte;
    GameObject carti;
    ViataPlayer viataPlayer;
    public GameObject player;
    public bool meniuMoarteDeschis=false;

    void Start()
    {
        carti =GameObject.Find("/Carti"); 
        meniuMoarteDeschis=false;
        viataPlayer = player.GetComponent<ViataPlayer>();
    }
    void Update()
    {
        if(viataPlayer.health<=0)
        {
            StartCoroutine(Meniu());
        }
    }

        IEnumerator Meniu()
    {
        cardManager.cardsIindex = 0;
        cardManager.cardsIIindex = 0;
        cardManager.cardsIIIindex = 0;

        carti.SetActive(false);
        yield return new WaitForSeconds(1);
        meniuMoarte.SetActive(true);
        meniuMoarteDeschis=true;
        
    }
}
