using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moartScript : MonoBehaviour
{
    
    public GameObject meniuMoarte;
    public GameObject carti;
    ViataPlayer viataPlayer;
    public GameObject player;

    void Start()
    {
        player = GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player");
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
        carti.SetActive(false);
        yield return new WaitForSeconds(1);
        meniuMoarte.SetActive(true);
        
    }
}
