using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

    public Texture2D cursorTexture;
    private Vector2 cursorHotspot;
    RoomFirstDungeonGenerator generator;
    GameObject scriptGenerator;


    void Start()
    {

        cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
        
    }

    void Awake()
    {
        scriptGenerator=GameObject.Find("/GENERARE/RoomFirstMapGenerator");
        generator = scriptGenerator.GetComponent<RoomFirstDungeonGenerator>();
        generator.GenerateDungeon();
    }
}
