using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meniuPrincipal : MonoBehaviour
{

    public GameObject panelPrincipal;
    public GameObject panelSetari;
    public void ExitGame() 
    { 
        Application.Quit(); 
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("1");
    }

    public void Setari()
    {
        panelPrincipal.SetActive(false);
        panelSetari.SetActive(true);
    }

    public void BackSetari()
    {
        panelSetari.SetActive(false);
        panelPrincipal.SetActive(true);
    }
}
