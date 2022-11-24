using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Jumping : MonoBehaviour
{
    [SerializeField] AudioClip[] audioClip;

    private AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Thats the Animation Event
    private void Jump()
    {
        AudioClip clip = GetRandomClip();
        audioSource.PlayOneShot(clip);
    }    
    
    private AudioClip GetRandomClip()
    {
        int index = Random.Range(0, audioClip.Length - 1);
        return audioClip[index];
    }
}
