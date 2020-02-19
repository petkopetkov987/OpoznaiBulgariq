using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prilep3TriggerFrame2 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilep3BoolFrame2", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilep3BoolFrame2", false);
        }
    }
}

