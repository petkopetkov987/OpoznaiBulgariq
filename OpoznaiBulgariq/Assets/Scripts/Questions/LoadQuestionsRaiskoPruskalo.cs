using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadQuestionsRaiskoPruskalo : MonoBehaviour
{
    public GameObject guiObject;

    void Start ()
    {
        guiObject.SetActive(false);
    }

    void OnTriggerStay2D (Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                SceneManager.LoadScene("QuestionsRaiskoPruskalo");
            }
        }
    }

    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}