using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trowGrenade : MonoBehaviour
{
    public useCardII grenadeCard;
    public float force;
    public GameObject grenade;
    private Transform grenadeT;
    private Vector3 endPos;
    public Transform punctDeTragere;

    public float throwDis;
    public float throwDuration;

    void Update()
    {
        punctDeTragere=GameObject.Find("/GENERARE/SPAWNED/parinte player(Clone)/player/arma/punctTragere").GetComponent<Transform>();
        if(grenadeCard.cardUsed)
        {          // StartCoroutine(ExplodeGrenade());
            Arunca();
        }
    }

    void Arunca()
    {
        GameObject grenade11 = Instantiate(grenade, punctDeTragere.position, punctDeTragere.rotation);
        grenadeT = grenade.GetComponent<Transform>();
        //se calculeaza pozitia finala
        endPos = new Vector3(grenadeT.position.x, grenadeT.position.y + throwDis, 0);
        //arunca grenada
        
        grenade11.GetComponent<Rigidbody2D>().AddForce(punctDeTragere.up * force, ForceMode2D.Impulse);
    }

    IEnumerator ExplodeGrenade()
    {
        
        Arunca();
        yield return null;
    }
}
