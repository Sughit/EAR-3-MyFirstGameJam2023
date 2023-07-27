using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwFlash : MonoBehaviour
{
    public useCardII flashCard;
    public float force;
    public GameObject flash;
    
    public Transform punctDeTragere;
    


    void Update()
    {
        punctDeTragere=GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player/arma/punctTragere").GetComponent<Transform>();
        if(flashCard.cardUsed)
        {
            Arunca();
            
        }
    }

    void Arunca()
    {
        GameObject flash11 = Instantiate(flash, punctDeTragere.position, punctDeTragere.rotation);
        //arunca grenada
        flash11.GetComponent<Rigidbody2D>().AddForce(punctDeTragere.up * force, ForceMode2D.Impulse);
    }
}
