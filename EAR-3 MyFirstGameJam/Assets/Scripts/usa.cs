using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class usa : MonoBehaviour
{
    RoomFirstDungeonGenerator generator;
    public bool isInRange;
    public Text doorText;

    private void OnEnterTrigger2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorText.gameObject.SetActive(true);
            isInRange = true;
        }
    }

    private void OnExitTrigger2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            doorText.gameObject.SetActive(false);
            isInRange = false;
        }
    }

    void Start()
    {
        doorText = GameObject.Find("Canvas/doorText").GetComponent<Text>();
        generator = GameObject.Find("GENERARE/RoomFirstMapGenerator").GetComponent<RoomFirstDungeonGenerator>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown("space"))
        {
            if(isInRange)
            {
                generator.GenerateDungeon();
            }
        }
    }
}
