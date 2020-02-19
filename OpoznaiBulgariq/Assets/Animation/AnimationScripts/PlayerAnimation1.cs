using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;
    private bool RunAnimation = false;

    void start() 
    {
        animator = GetComponent<Animator>();
    }

    void update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !RunAnimation) 
        {
            animator.SetBool("RunAnimation", true);
            RunAnimation = true;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && RunAnimation)
        {
            animator.SetBool("RunAnimation", false);
            RunAnimation = false;
        }
    }
}
