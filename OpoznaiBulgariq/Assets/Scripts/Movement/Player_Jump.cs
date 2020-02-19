using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Jump : MonoBehaviour
{
    public float jumpForce = 300.0f;

    public Transform groundCheck;
    public float groundRadius = 1f;
    public bool grounded = false;
    public LayerMask whatIsGround;

    void FixedUpdate()
    {
        bool jump = Input.GetButtonDown("Jump");

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

        if (jump && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);
        }
    }
}
