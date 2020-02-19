using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prilep4TriggerFrame2 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilep4BoolFrame2", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilep4BoolFrame2", false);
        }
    }
}

