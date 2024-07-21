using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MeleeScriptableObject",menuName = "ScriptableObjects/MeleeEnemy")]
public class MeleeScriptableObject : ScriptableObject
{
    

    public float attackSpeed = 5f;

    public float attackDamage  = 5f;
        
    public AudioClip AudioClip;
    
    
}
