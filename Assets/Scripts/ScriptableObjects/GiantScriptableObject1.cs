using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/GiantEnemy")]
public class GiantScriptableObject : ScriptableObject
{
    public float attackSpeed = 3f;

    public float attackDamage  = 10f;
        
    public AudioClip AudioClip;
}
