using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class MyKeyboardKey : MonoBehaviour
{
    public AudioSource audioSource;
    public KeyCode keyboardLetter;
    public AudioClip audioClip;

    void PlayKey()
    {
        audioSource.PlayOneShot(audioClip);
    }

    private void Update()
    {
        if(Input.GetKeyDown(keyboardLetter))
        {
            PlayKey();
        }
    }
}
