using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    private bool _isPaused;
    private static Pause _instanse;

    private void Awake()
    {
        if (_instanse != null)
        {
            Destroy(gameObject);
            return;
        }
        _instanse = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuEnableOrDisable();
        }    
    }

    private void PauseMenuEnableOrDisable()
    {
        _isPaused = !_isPaused;
        _menu.SetActive(_isPaused);
        Time.timeScale = _isPaused == true ? 0 : 1;
    }
}
