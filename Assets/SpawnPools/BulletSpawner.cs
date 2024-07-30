using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : BasePooler<GameObject>
{
    public Transform Muzzle;

    private float _lastAttackTime = -1f;
    public float gunCooldown = 0.25f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= _lastAttackTime + gunCooldown)
        {
            var item = GetItem();
            item.SetActive(true);
            item.transform.position = Muzzle.position;
            
            var bulletMovement = item.GetComponent<BulletMovement>();
            if (bulletMovement != null)
            {
                bulletMovement.Initialize(this);
            }

            _lastAttackTime = Time.time;
        }
    }
}