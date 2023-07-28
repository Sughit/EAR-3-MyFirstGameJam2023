using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wanderingAI : MonoBehaviour
{
    public Transform inamic;
    public float speed=0.02f;
    private List<Vector3> Directii = new List<Vector3>
    {
        new Vector3(0,1,0),
        new Vector3(1,0,0),
        new Vector3(0,-1,0),
        new Vector3(-1,0,0)
    };
    void Start()
    {
        Debug.Log(Directii[Random.Range(1,Directii.Count)]);
        inamic = GetComponent<Transform>();
    }
    void Update()
    {
        inamic.Translate(Directii[Random.Range(1,Directii.Count)]*Time.deltaTime* speed);
    }
}
