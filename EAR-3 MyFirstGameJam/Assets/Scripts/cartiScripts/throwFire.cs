using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwFire : MonoBehaviour
{
    public useCardII fireCard;
    public float force;
    public GameObject fire;
    
    public Transform punctDeTragere;
    


    void Update()
    {
        punctDeTragere=GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player/arma/punctTragere").GetComponent<Transform>();
        if(fireCard.cardUsed)
        {
            Arunca();
            
        }
    }

    void Arunca()
    {
        GameObject fire11 = Instantiate(fire, punctDeTragere.position, punctDeTragere.rotation);
        //arunca focul
        fire11.GetComponent<Rigidbody2D>().AddForce(punctDeTragere.up * force, ForceMode2D.Impulse);
    }
}
