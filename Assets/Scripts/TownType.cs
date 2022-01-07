using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Town Type",menuName = "Town Type")]
public class TownType : ScriptableObject
{
    public float currentLevel;
    public float maxLevel;
    public float fee;
    public float constructionTime;
    
}
