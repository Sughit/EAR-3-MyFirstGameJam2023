using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwSmoke : MonoBehaviour
{
    public useCardII smokeCard;
    public float force;
    public GameObject smoke;
    
    public Transform punctDeTragere;
    


    void Update()
    {
        punctDeTragere=GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player/arma/punctTragere").GetComponent<Transform>();
        if(smokeCard.cardUsed)
        {
            Arunca();
            
        }
    }

    void Arunca()
    {
        GameObject smoke11 = Instantiate(smoke, punctDeTragere.position, punctDeTragere.rotation);
        //arunca grenada
        smoke11.GetComponent<Rigidbody2D>().AddForce(punctDeTragere.up * force, ForceMode2D.Impulse);
    }
}
