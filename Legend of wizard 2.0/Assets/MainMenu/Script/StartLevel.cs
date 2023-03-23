using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLevel : MonoBehaviour
{
    public void ToStart()
    {
        SceneManager.LoadScene(1);
    }
}
