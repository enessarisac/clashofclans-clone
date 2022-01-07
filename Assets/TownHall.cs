using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownHall : MonoBehaviour
{
    [SerializeField]private TownType townType=null;
    public Town town;
    public float level;
    public float charge;
    public float time,requiredTime;
    public  bool construction;
    private void Start()
    {
        level=townType.currentLevel;
        charge=townType.fee;
        requiredTime=townType.constructionTime;


        StartCoroutine(check());
    }
    IEnumerator check()
    {
        townType.currentLevel=level;
        townType.fee=charge;
        yield return new WaitForSeconds(2f);
    }
    private void Update() 
    {
        if(construction)
        {
            Upgrading();
        }
    }
    public void onUpgrade()
    {
        if(!construction)
        {
        construction=true;
        time=requiredTime;
        check();
        }
        
    }
    public void Upgrading()
    {

        time-=1*Time.deltaTime;
        if(time<=0)
        {
            level++;
            charge=charge*2;
            requiredTime=requiredTime*2;
            construction=false;
        }
    }

}
