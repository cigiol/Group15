using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TrapScriptableObject")]
public class TrapScriptableObject : ScriptableObject
{
    public float Damage = 20f;
    
    public AudioClip AudioClip;
    
}