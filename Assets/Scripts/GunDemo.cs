using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunDemo : MonoBehaviour,IWeapons
{
    private BulletSpawner _bulletSpawner;
    
    public void PlayerAttack()
    {
        _bulletSpawner.GetItem();
        Debug.Log("Bullet Released");
    }
}
