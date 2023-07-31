using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeExplode : MonoBehaviour
{
    public float timeToExplode;
    public GameObject smoke;
    public GameObject doubleSmoke;
    public float smokedTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExplodeSmoke());
    }

    IEnumerator ExplodeSmoke()
    {
        yield return new WaitForSeconds(timeToExplode);
        Debug.Log("smoke exploded");
        if(doubleProjectilesCard.doubleSmoke)
        {
            Instantiate(doubleSmoke, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(smoke, transform.position, transform.rotation);
        }
        StartCoroutine(Smoked());

        yield return null;
    }
    
    IEnumerator Smoked()
    {
        yield return new WaitForSeconds(smokedTime);
        Destroy(gameObject);
    }

}
