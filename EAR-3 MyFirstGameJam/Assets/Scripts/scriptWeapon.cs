using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptWeapon : MonoBehaviour
{
    public GameObject glontPrefab;
    public Transform punctTragere;
    public float forta=20f;
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    public void Fire()
    {
        GameObject bullet = Instantiate(glontPrefab, punctTragere.position, punctTragere.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(punctTragere.up * forta, ForceMode2D.Impulse);
    }
}

