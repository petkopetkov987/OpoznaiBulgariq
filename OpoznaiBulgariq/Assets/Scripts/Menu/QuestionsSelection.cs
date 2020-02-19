using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestionsSelection : MonoBehaviour
{
    public void questionsScene()
    {
        switch (this.gameObject.name)
        {
            case "ButtonQuestionsSnejanka":
                SceneManager.LoadScene("QuestionsSnejanka");
                break;
            case "ButtonQuestionsDobrudja":
                SceneManager.LoadScene("QuestionsDobrudja");
                break;
            case "ButtonQuestionsChernoMore":
                SceneManager.LoadScene("QuestionsChernoMore");
                break;
            case "ButtonQuestionsRaiskoPruskalo":
                SceneManager.LoadScene("QuestionsRaiskoPruskalo");
                break;
            case "ButtonQuestionsMusala":
                SceneManager.LoadScene("QuestionsMusala");
                break;
        }
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}