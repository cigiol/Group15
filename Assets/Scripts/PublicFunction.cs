using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicFunction : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private AreaDamager _areaDamager;

    private BulletMovement _bulletMovement;

    private MagicBarrier _magicBarrier;
    
    private bool ısActive;
    
    public bool shield = false;

    public float armour = 0;
    
    public void Deneme(){
      Debug.LogWarning("Working");  
    } 
    

    public void ArmourIncreaser()
    {
        _playerMovement.armour += 1f;
    }

    public void ShieldHandler()
    {
        if (!shield)
        {
            shield = true;
        }

        else
        {
            _playerMovement.shieldCooldown -= 3;
        }
    }

    public void MoveSpeedIncreaser()
    {
        _playerMovement.moveSpeed += 1f;
    }

    public void HealthIncreaser()
    {
        _playerMovement.health += 25f;
    }

    public void GunDamage()
    {
        _bulletMovement.BulletDamage += 15;
    }

    public void AreaDamage()
    {
        if (!_areaDamager.isActive)
        {
            _areaDamager.Activater();
        }

        else
        {
            _areaDamager.damage += 10;
        }
    }

    public void Barrier()
    {
        if (!_magicBarrier.IsActive)
        {
            _magicBarrier.Activator();
        }
        
        else
        {
            _magicBarrier.MaksHitAmount += 1;
            _magicBarrier.hitAmount = _magicBarrier.MaksHitAmount;
        }

        
    }







}
