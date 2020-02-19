using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "ButtonSnejanka":
                SceneManager.LoadScene("LevelSnejanka");
                break;
            case "ButtonDobrudja":
                SceneManager.LoadScene("LevelDobrudja");
                break;
            case "ButtonChernoMore":
                SceneManager.LoadScene("LevelChernoMore");
                break;
            case "ButtonRaiskoPruskalo":
                SceneManager.LoadScene("LevelRaiskoPruskalo");
                break;
            case "ButtonMusala":
                SceneManager.LoadScene("LevelMusala");
                break;
        }
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}