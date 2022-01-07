using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine;

public class Town : MonoBehaviour
{
    public GameObject upgradeButton;
    private void Update() 
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
        RaycastHit hit; 
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
            if (Physics.Raycast(ray,out hit))
            {
                    
                    if(hit.transform.tag=="Town") 
                        upgradeButton.SetActive(true);
                    if(hit.transform.tag=="Ground")
                        upgradeButton.SetActive(false);
            }
        }
    }
}