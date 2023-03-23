using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    public void ToStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ToSettings()
    {
        SceneManager.LoadScene(4);
    }
}
