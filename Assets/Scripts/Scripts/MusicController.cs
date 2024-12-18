using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip levelMusic;






    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        playMusic(levelMusic);
    }

    public void playMusic(AudioClip music)
    {
        audioSource.clip = music;

        audioSource.Play();

    }
}
