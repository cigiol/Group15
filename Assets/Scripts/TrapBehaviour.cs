using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehaviour : MonoBehaviour
{
    private TrapPooler _trapPooler;
    
    private void Initialize(TrapPooler spawner)
    {
        _trapPooler = spawner;
        Debug.Log("TrapPooler initialized.");
    }

    private void Start()
    {
        Initialize(_trapPooler);
    }


    // Called when another collider enters the trigger collider attached to this object
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
        
        if (other.gameObject.CompareTag("Player"))
        {
            if (_trapPooler != null)
            {
                Debug.Log("Trap activated and deactivated.");
                _trapPooler.ReleaseItem(gameObject);
            }
            else
            {
                Debug.LogError("TrapPooler is not initialized.");
            }
        }
    }
}