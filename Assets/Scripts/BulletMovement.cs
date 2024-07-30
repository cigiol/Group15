using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private BulletSpawner _bulletSpawner;
    private Rigidbody rb;
    [SerializeField] private float bulletSpeed = 1f;
    [SerializeField] private float timeLimit = 5;

    // Initialize the bullet with a reference to the spawner
    public void Initialize(BulletSpawner spawner)
    {
        _bulletSpawner = spawner;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * bulletSpeed; // Set initial velocity
        
    }

    private void OnEnable()
    {
        Invoke("TimeLimit", timeLimit);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Deactivate the bullet
        gameObject.SetActive(false);

        // Check if the collider is not another bullet
        if (!other.gameObject.CompareTag("Bullet")&& other.gameObject.CompareTag("Player"))
        {
            if (_bulletSpawner != null)
            {
                _bulletSpawner.ReleaseItem(gameObject);
                Debug.Log("Released");
            }
            else
            {
                Debug.LogError("BulletSpawner reference is not set!");
            }
        }
    }

    private void TimeLimit()
    {
        if (_bulletSpawner != null)
        {
            _bulletSpawner.ReleaseItem(gameObject);
            Debug.Log("TimeLimited");
        }
        gameObject.SetActive(false); // Deactivate the bullet
    }
}