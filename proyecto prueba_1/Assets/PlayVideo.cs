using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;  // Asigna el Video Player desde el Inspector

    void Start()
    {
        videoPlayer.Play();  // Reproduce el video cuando comienza el juego
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))  // Reproduce o pausa el video cuando presionas la tecla "P"
        {
            if (videoPlayer.isPlaying)
                videoPlayer.Pause();
            else
                videoPlayer.Play();
        }
    }
}
