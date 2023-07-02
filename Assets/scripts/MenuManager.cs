using UnityEngine;
using UnityEngine.SceneManagement;


public class SettingManager : MonoBehaviour
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
        Application.Quit();
    }
  
}
