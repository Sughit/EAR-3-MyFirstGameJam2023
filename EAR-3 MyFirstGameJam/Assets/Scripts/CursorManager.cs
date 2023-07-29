using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{

    public Texture2D cursorTexture;
    private Vector2 cursorHotspot;
    RoomFirstDungeonGenerator generator;
    GameObject scriptGenerator;
    AudioSource muzica;


    void Start()
    {   
        Time.timeScale = 0f;

        cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
        Cursor.lockState = CursorLockMode.Confined;
        
    }

    void Awake()
    {
        scriptGenerator=GameObject.Find("/GENERARE/RoomFirstMapGenerator");
        generator = scriptGenerator.GetComponent<RoomFirstDungeonGenerator>();
        generator.GenerateDungeon();
        muzica = GetComponent<AudioSource>();
        muzica.Play(0);
         
    }

    public void SaInceapaAventura()
    {
        Time.timeScale = 1f;
    }
}
