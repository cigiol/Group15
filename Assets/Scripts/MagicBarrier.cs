using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBarrier : MonoBehaviour
{
    public bool IsActive = true;
    public int MaksHitAmount = 1;
    public int hitAmount;

    public Transform Player;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position;

        if (hitAmount <= 0)
        {
            gameObject.SetActive(false);
            Invoke("Activator",15);
        }
    }

    public void Activator()
    {
        IsActive = true;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("GiantEnemy") && other.gameObject.CompareTag("MeleeEnemy") && other.gameObject.CompareTag("RangedEnemy") && other.gameObject.CompareTag("Trap"))
        {
            hitAmount -= 1;
        }
    }

    private void DeActivator()
    {
       
    }
}
