using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Defence Type",menuName = "Defence Type")]
public class DefenceType : ScriptableObject
{
   public float health;
   public float damage;
   public float attackRange; 
}
