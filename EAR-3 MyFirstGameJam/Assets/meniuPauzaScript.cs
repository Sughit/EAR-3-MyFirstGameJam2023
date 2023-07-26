using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meniuPauzaScript : MonoBehaviour
{


    public GameObject meniuPauza;
    public bool meniuDeschis;
    public GameObject meniuMoarte;
    moartScript scriptMoarte;
    
    void Start()
    {
        scriptMoarte = meniuMoarte.GetComponent<moartScript>();
    }
    
    void Update()
    {
        if(Time.timeScale==1f  && scriptMoarte.meniuMoarteDeschis==false)
        {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("dwdwd");
            Time.timeScale=0f;
            meniuPauza.SetActive(true);
            meniuDeschis=true;
        }
        }
        else if(meniuDeschis)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                meniuPauza.SetActive(false);
                Time.timeScale=1f;
                meniuDeschis=false;
            }
        }
        
    }

    public void resume()
    {
        meniuPauza.SetActive(false);
        Time.timeScale=1f;
        meniuDeschis=false;
    }
}
