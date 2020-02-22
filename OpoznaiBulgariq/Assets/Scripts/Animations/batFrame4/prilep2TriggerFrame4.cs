﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prilep2TriggerFrame4 : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilep2BoolFrame4", true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            myAnimationController.SetBool("prilep2BoolFrame4", false);
        }
    }
}

