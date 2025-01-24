using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager1 : MonoBehaviour
{
    public static AudioManager1 instance;

    public AudioClip background;
    public AudioClip shoot;
    public AudioClip hurt;
    public AudioClip gameover;
    public AudioClip donut;
    public AudioSource audioSource;
    public AudioSource playDestroySound;
    public AudioSource playShootSound;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayShootSound()
    {
        audioSource.PlayOneShot(shoot);
    }

    public void PlayDestroySound()
    {
        audioSource.PlayOneShot(hurt);
    }
}

