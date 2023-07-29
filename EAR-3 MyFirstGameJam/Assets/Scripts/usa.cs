using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class usa : MonoBehaviour
{
    public Text doorText;
    public bool isInRange;
    RoomFirstDungeonGenerator toNextFloor;

    // Start is called before the first frame update
    void Start()
    {
        doorText = GameObject.Find("Carti/door/doorText").GetComponent<Text>();
        toNextFloor = GameObject.Find("GENERARE/RoomFirstMapGenerator").GetComponent<RoomFirstDungeonGenerator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            doorText.gameObject.SetActive(true);
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            doorText.gameObject.SetActive(false);
            isInRange = false;
        }
    }

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            if(isInRange)
            {
                Debug.Log("went to the next floor");
                ViataEnemy.health += 2f;
                glontInamic.damage += 2f;
                toNextFloor.GenerateDungeon();
            }
        }
    }
}
