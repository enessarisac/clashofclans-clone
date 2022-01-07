using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Soldier Type",menuName = "Soldier Type")]
public class SoldierType : ScriptableObject
{
    public Color soldierColor;
    public float speed;
    public Vector3 soldierScale = Vector3.one;
    public string typeName= "Type";
    public string favouriteTarget ="Target Tag";
    public float power;
}
