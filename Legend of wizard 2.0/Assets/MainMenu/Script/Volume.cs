using UnityEngine.UI;
using UnityEngine;

public class Volume : MonoBehaviour
{
    public Slider volume;
    public AudioSource audio;

    private void Update() 
    {
        audio.volume = volume.value;
    }

    public void OnOffAudio()
    {
        if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }
}
