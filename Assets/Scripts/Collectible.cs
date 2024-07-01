using System;
using UnityEngine;
using UnityEngine.Events;
public class Collectible : MonoBehaviour
{
    public UnityEvent<Collectible> OnCollectibleCollected;
    
     private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player")){
            Destroy(gameObject);
            OnCollectibleCollected.Invoke(this);
		}
	}
}
