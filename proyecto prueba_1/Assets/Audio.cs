using UnityEngine;

public class AudioControlScript : MonoBehaviour
{
    public AudioSource audioSource;  // Referencia al componente AudioSource

    // Método para reproducir el audio
    public void PlayAudio()
    {
        if (!audioSource.isPlaying) // Solo reproducir si no se está reproduciendo ya
        {
            audioSource.Play();
        }
    }

    // Método para pausar el audio
    public void PauseAudio()
    {
        if (audioSource.isPlaying) // Pausar solo si se está reproduciendo
        {
            audioSource.Pause();
        }
    }
}