using System;
using UnityEngine;

public class PlayerAttackHandler : MonoBehaviour
{
    // Interface reference
    private IWeapons _iWeapons;

    
    void Start()
    {
        _iWeapons = GetComponent<IWeapons>();
    }

    
    private void FixedUpdate()
    {
        if (_iWeapons != null && Input.GetKey(KeyCode.Mouse0))
        {
            _iWeapons.PlayerAttack();
        }
    }
}