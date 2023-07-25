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
        if(grenadeCard.cardUsed)
        {
            Instantiate(grenade, punctDeTragere.position, punctDeTragere.rotation);
            // StartCoroutine(ExplodeGrenade());
            Arunca();
        }
    }

    void Arunca()
    {
        grenadeT = grenade.GetComponent<Transform>();
        //se calculeaza pozitia finala
        endPos = new Vector3(grenadeT.position.x, grenadeT.position.y + throwDis, 0);
        //arunca grenada
        grenadeT.position = Vector3.Lerp(Vector3.up, endPos, throwDuration);
    }

    IEnumerator ExplodeGrenade()
    {
        
        Arunca();
        yield return null;
    }
}
