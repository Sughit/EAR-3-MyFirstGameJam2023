using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
     AudioSource poc;

   /* void Awake()
    {
        poc = GetComponent<AudioSource>();
        poc.Play(0);

    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    void Update()
    {
        Object.Destroy(gameObject, 5.0f);
    }
}
