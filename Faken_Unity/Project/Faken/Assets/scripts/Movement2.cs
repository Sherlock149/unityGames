using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2 : MonoBehaviour
{
    public CharacterController2D2 controller2;
    public fight fighter;
    float horizontalMove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    public bool crouch = false;
    public Animator animator2;
    public Rigidbody2D rb2;
    Vector2 vel;
    public Vector2 loc2;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal2") * runspeed;
        if (Input.GetButtonDown("Jump2"))
        {
            jump = true;
            animator2.SetBool("isjump", true);
        }

        if (Input.GetButtonDown("crouch2"))
        {
            crouch = true;
            animator2.SetBool("iscrouch", true);
        }
        else if (Input.GetButtonUp("crouch2"))
        {
            crouch = false;
            animator2.SetBool("iscrouch", false);
        }
        if (Input.GetButtonDown("attack2"))
        {
            animator2.SetBool("isattack", true);
        }
        else if (Input.GetButtonUp("attack2"))
        {
            animator2.SetBool("isattack", false);
        }
    }

    void FixedUpdate()
    {
        controller2.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        loc2 = rb2.position;
        vel = rb2.velocity;
        if (vel.y < 0)
            animator2.SetBool("isjump", false);

        //animator.SetBool("isjump", false);
    }
}

