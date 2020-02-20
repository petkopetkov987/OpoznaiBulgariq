using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float runSpeed = 10.0f;
    public bool facingRight = true;
    public Animator animator;

    void Start()
    {

    }
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(move));

        if (move < 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(move * runSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (move > 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(move * runSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        if (move < 0 && facingRight)
        {
            Flip();
        }
        if (move > 0 && !facingRight)
        {
            Flip();
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(Vector3.up * 180);
    }
}
