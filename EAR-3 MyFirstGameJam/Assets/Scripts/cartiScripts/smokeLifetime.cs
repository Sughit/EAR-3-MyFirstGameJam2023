using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeLifetime : MonoBehaviour
{

    public float lifeTime;
    void Awake()
    {
        StartCoroutine(LifeTime());
    }

    IEnumerator LifeTime()
    {
        Debug.Log("smoke time begun");
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
