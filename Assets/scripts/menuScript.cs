using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menuScript : MonoBehaviour
{

    public GameObject settings;
    public GameObject MainMenu;

    public void Startgame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void LoadSettings()
    {
        MainMenu.SetActive(false);
        settings.SetActive(true);
    }
    public void quit()
    {
        Debug.Log("quiting the game...");
        Application.Quit();
    }
}
