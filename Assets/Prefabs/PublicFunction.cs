using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicFunction : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    private bool player1Activater = false;
    private bool player2Activater = false;

    public bool shield = false;
    void Start()
    {
        if (player1Activater)
        {
            gameObject.SetActive(true);
        }

        else
        {
            gameObject.SetActive(false);
        }
    }
    
    public void Deneme(){
      Debug.LogWarning("Working");  
    } 
    
    public void Player1Activater()
    {
        player1Activater = true;
    }
    
    public void Player2Activater()
    {
        player2Activater = true;
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
    
    
    
    



}
