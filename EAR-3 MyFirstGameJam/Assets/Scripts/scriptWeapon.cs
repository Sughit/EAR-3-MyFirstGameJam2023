using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scriptWeapon : MonoBehaviour
{
    public GameObject glontPrefab;
    public Transform punctTragere;
    public float forta=20f;
    public float fireRate=7f;
    private bool canFire=true;
    public float ammo=30;
    public Text textAmmo;
    public GameObject incarcator;
    public GameObject sunet;
    AudioSource rePoc;


    Vector2 lookDirection;
    float lookAngle;
    
    void Start()
    {
        textAmmo = GameObject.Find("Canvas/ammoPanel/TextAmmo").GetComponent<Text>();
    }

    void Update()
    {
        if(textAmmo == null)
        {
            textAmmo = GameObject.Find("Canvas/ammoPanel/TextAmmo").GetComponent<Text>();
        }

        if(ammo<30)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                StartCoroutine(Reload());
            } 
        }


                textAmmo.text = ammo.ToString();


    }

    

    void FixedUpdate()
    {
        if(ammo>0)
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
    }


    IEnumerator Reload()
    {
        ammo=0;
        if(ammo<30)
        {
            incarcator.GetComponent<Animator>().Play("reload");
        }
        rePoc = GetComponent<AudioSource>();
        rePoc.Play(0);
        yield return new WaitForSeconds(2);
        ammo=30;
        

        

    }



    IEnumerator Fire()
    {
        GameObject bullet = Instantiate(glontPrefab, punctTragere.position, punctTragere.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(punctTragere.up * forta, ForceMode2D.Impulse);
        canFire=false; 
        Instantiate(sunet);
        ammo--;
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

