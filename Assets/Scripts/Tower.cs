using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private DefenceType defenceType=null;
    public Soldiers soldiers=null;
    public float health;
    void Start()
    {
        health=defenceType.health;
    }

    
    void Update()
    {
        
        soldiers=GameObject.FindGameObjectWithTag("Soldier").GetComponent<Soldiers>();
        if(soldiers.attack==true)
        {
            TakeDamage();
        }
        if(health<0)
        {
            Destroy(this.gameObject);
        }
    }
    public void TakeDamage()
    {
      health=health-5;
    }
}
