using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prilepTriggerFrame4 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilepBoolFrame4", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilepBoolFrame4", false);
        }
    }
}

