using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaDamager : MonoBehaviour
{
    public bool isActive = true;

    public int damage = 15;
    
    public Transform centerObject; // The object to rotate around
    [SerializeField] private float speed = 10f; // Rotation speed

    void Update()
    {
        if (centerObject != null)
        {
            // Rotate around the center object along the y-axis
            transform.RotateAround(centerObject.position, Vector3.up, speed * Time.deltaTime);
        }
    }

    public void Activater()
    {
        gameObject.SetActive(true);
    }
}
