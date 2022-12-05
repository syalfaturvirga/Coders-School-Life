using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSound : MonoBehaviour
{
    public static ManagerSound Instance { get; set; }

    public AudioSource audioMusic;
    public AudioClip[] clipMusic;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
