using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScript : MonoBehaviour
{
    // public GameObject MainMenu;

    void Start()
    {        

    }

    public void ButtonButton()
    {
        print("button button");
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuScene");

    }

    public void LoadCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
    }
}