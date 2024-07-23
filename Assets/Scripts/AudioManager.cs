using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip SFXSource;

    public AudioClip background;

    private void Start()
    {
        if (background == null)
        {
            Debug.LogError("Background AudioClip is not assigned.");
            return;
        }

        if (musicSource == null)
        {
            Debug.LogError("Music AudioSource is not assigned.");
            return;
        }

        musicSource.clip = background;
        musicSource.Play();

        if (!musicSource.isPlaying)
        {
            Debug.LogError("Background music failed to play.");
        }
        else
        {
            Debug.Log("Background music is playing.");
        }
    }
}
