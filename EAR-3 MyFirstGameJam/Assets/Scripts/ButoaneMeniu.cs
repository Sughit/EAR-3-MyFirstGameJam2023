using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButoaneMeniu : MonoBehaviour
{
    usa usa;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        usa.floor=0;

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("meniuPrincipal");
    }

}
