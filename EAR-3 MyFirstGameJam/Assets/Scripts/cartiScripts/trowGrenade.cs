using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trowGrenade : MonoBehaviour
{
    public useCardII grenadeCard;
    public float force;
    public GameObject grenade;
    
    public Transform punctDeTragere;
    


    void Update()
    {
        punctDeTragere=GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player/arma/punctTragere").GetComponent<Transform>();
        if(grenadeCard.cardUsed)
        {
            Arunca();
            
        }
    }

    void Arunca()
    {
        GameObject grenade11 = Instantiate(grenade, punctDeTragere.position, punctDeTragere.rotation);
        //arunca grenada
        grenade11.GetComponent<Rigidbody2D>().AddForce(punctDeTragere.up * force, ForceMode2D.Impulse);
    }

    
}
