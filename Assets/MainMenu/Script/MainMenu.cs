using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ToStart()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsEnable()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
