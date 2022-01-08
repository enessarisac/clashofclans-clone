using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerSources : MonoBehaviour
{
    public float money,elixir;
    public Text moneyText,elixirText;
    private void Start() 
    {
        moneyText.text=money.ToString();
        elixirText.text=elixir.ToString();
        StartCoroutine(ControlTexts());
    }

    IEnumerator ControlTexts()
    {
        while(true)
        {
            elixirText.text=elixir.ToString();
            moneyText.text=money.ToString();
            yield return new WaitForSeconds(0.3f);
        }
    }
        
}
