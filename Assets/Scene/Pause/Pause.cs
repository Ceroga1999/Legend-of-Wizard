using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject canvas;
    bool pause = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOnOff();
        }    
    }

    void PauseOnOff()
    {
        pause = !pause;
        canvas.SetActive(pause);
    }
}
