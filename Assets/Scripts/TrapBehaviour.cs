using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    private AudioSource _audioSource;
    private TrapScriptableObject _trapScriptableObject;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        _audioSource.clip = _trapScriptableObject.AudioClip;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            _audioSource.Play();
            
           gameObject.SetActive(false);
        }
    }
}