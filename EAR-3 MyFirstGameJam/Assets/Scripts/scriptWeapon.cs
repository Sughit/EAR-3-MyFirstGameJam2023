using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptWeapon : MonoBehaviour
{
    public GameObject glontPrefab;
    public Transform punctTragere;
    public float forta=20f;
    public float fireRate;
    private bool canFire=true;
    
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(canFire)
            {
                GetComponent<Animator>().Play("animatietras");
                StartCoroutine(Fire());  
            }
        }
    }
    IEnumerator Fire()
    {
        GameObject bullet = Instantiate(glontPrefab, punctTragere.position, punctTragere.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(punctTragere.up * forta, ForceMode2D.Impulse);
        canFire=false;
        StartCoroutine(FireRateHandler());
        yield return null;
    }

 
  
    IEnumerator FireRateHandler() 
    {
        float timeToNextFire= 1 / fireRate;
        yield return new WaitForSeconds(timeToNextFire);
        canFire=true;
        
        
    }
}

