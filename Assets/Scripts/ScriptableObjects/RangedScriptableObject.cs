using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/RangedEnemy")]
public class RangedScriptableObject : ScriptableObject
{
    public float attackSpeed = 8f;

    public float attackDamage  = 3f;
        
    public AudioClip AudioClip;
    
}