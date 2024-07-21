using System;
using UnityEngine;

public class MeleeEnenmyTest : MonoBehaviour
{
    [SerializeField] private MeleeScriptableObject meleeScriptableObject;
    
    private AudioSource audioSource; // Reference to the AudioSource

    void Start()
    {
        // Get the AudioSource component attached to the GameObject
        audioSource = GetComponent<AudioSource>();

        // Check if AudioSource is found
        if (audioSource == null)
        {
            Debug.LogError("AudioSource component missing from this GameObject. Please add one.");
            return;
        }

        // Assign the AudioClip to the AudioSource
        audioSource.clip = meleeScriptableObject.AudioClip;
    }

    private void Update()
    {
        PlayAudio();
    }

    public void PlayAudio() // Check the condition
    {
        if (Input.GetKey(KeyCode.S))
        {
            audioSource.Play();
            Debug.Log("Key Pressed");
        }
       
    }
}