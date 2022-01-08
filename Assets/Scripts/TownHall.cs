using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TownHall : MonoBehaviour
{
    [SerializeField]private TownType townType=null;
    [SerializeField]private PlayerSources playerSources=null;
    public Town town;
    public float level;
    public Button levelUpbutton;
    public float charge;
    public Text levelText,requiredMoneyText,consText;
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
        while(true)
        {
            requiredMoneyText.text=(charge.ToString());
            levelText.text=(level.ToString());
            townType.currentLevel=level;
            townType.fee=charge;
            townType.constructionTime=requiredTime;
            yield return new WaitForSeconds(2f);
        }
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
        if(!construction&&playerSources.money>charge)
        {
        playerSources.money-=charge;
        construction=true;
        time=requiredTime;
        levelUpbutton.interactable=true;
        }
        if(playerSources.money<charge)
        {
            levelUpbutton.interactable=false;
        }
        
    }
    public void Upgrading()
    {
        consText.text=(time.ToString());
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
