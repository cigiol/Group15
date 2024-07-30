using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamageCalc : MonoBehaviour
{
    private PublicFunction _publicFunction;

    private TrapScriptableObject _trapScriptableObject;
    private MeleeScriptableObject _meleeScriptableObject;
    private RangedScriptableObject _rangedScriptableObject;
    private GiantScriptableObject _giantScriptableObject;

    private PlayerMovement _playerMovement;
    private MagicBarrier _magicBarrier;

    private void OnTriggerEnter(Collider other)
    {
        if (_magicBarrier.hitAmount <= 0)
        {
            if (other.gameObject.CompareTag("Trap"))
            {
                _playerMovement.health -= TrapDamageCalcuator();
            }
            else if (other.gameObject.CompareTag("MeleeEnemy"))
            {
                _playerMovement.health -= MeleeDamageCalcuator();
            }
            else if (other.gameObject.CompareTag("RangedEnemy"))
            {
                _playerMovement.health -= RangedDamageCalcuator();
            }
            else if (other.gameObject.CompareTag("GiantEnemy"))
            {
                _playerMovement.health -= GiantDamageCalcuator();
            }
        }
        
    }

    float MeleeDamageCalcuator()
    {
        return _meleeScriptableObject.attackDamage - _publicFunction.armour;
    }

    float TrapDamageCalcuator()
    {
        return _trapScriptableObject.Damage - _publicFunction.armour;
    }
    
    float RangedDamageCalcuator()
    {
        return _giantScriptableObject.attackDamage - _publicFunction.armour;
    }
    
    float GiantDamageCalcuator()
    {
        return _giantScriptableObject.attackDamage - _publicFunction.armour;
    }
}
