using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI : MonoBehaviour
{
    public void Attack()
    {
        SceneManager.LoadScene("AttackScene");
    }
}
