using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldiers : MonoBehaviour
{
    [SerializeField] private SoldierType soldierType=null;
    public GameObject targetObj=null;
    public Vector3 targetPos;
    public bool attack;
    public float distance,minDistance;
    void Start()
    {
        GetComponent<Renderer>().material.color=soldierType.soldierColor;
        transform.localScale=soldierType.soldierScale;
        targetObj=GameObject.FindGameObjectWithTag(soldierType.favouriteTarget);
        targetPos=targetObj.transform.position;     
    }
    void Update()
    {
        distance=Vector3.Distance(targetPos,transform.position);
        if(targetObj!=null)
        {
            FavouriteTarget();
        }

       
    }
    void FavouriteTarget()
    {
        if(minDistance<distance)
        {
            attack=false;
            transform.Translate(Vector3.Normalize(targetPos-transform.position) * soldierType.speed*Time.deltaTime);
        }else
        {
          attack=true;
        }
        
    }  
}
