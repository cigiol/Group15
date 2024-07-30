using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicFunction : MonoBehaviour
{
    private PlayerMovement _playerMovement;
    
    public bool shield = false;

    public float armour = 0;
    
    public void Deneme(){
      Debug.LogWarning("Working");  
    } 
    

    public void armorIncreaser()
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
        
    }

    public void areaDamage()
    {
        
    }

    public void ArmourIncreaser()
    {
        armour += 1;
    }







}
