using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartLevel : MonoBehaviour
{
    public int index;

    public void ToStart()
    {
        SceneManager.LoadScene(index);
    }
}
