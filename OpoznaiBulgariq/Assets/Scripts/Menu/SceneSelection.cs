using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour
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
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}