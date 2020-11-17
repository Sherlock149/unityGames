using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public CharacterController2D controller1;
    public fight fighter;
    float horizontalMove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    public bool crouch = false;
    public Animator animator;
    public Rigidbody2D rb;
    Vector2 vel;
    public Vector2 loc1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal1") * runspeed;
        if(Input.GetButtonDown("Jump1"))
        {
            jump = true;
            animator.SetBool("isjump", true);
        }
      
        if(Input.GetButtonDown("crouch1"))
        {
            crouch = true;
            animator.SetBool("iscrouch", true);
        } 
        else if (Input.GetButtonUp("crouch1"))
        {
            crouch = false;
            animator.SetBool("iscrouch", false);
        }
        if(Input.GetButtonDown("attack1"))
        {
            animator.SetBool("isattack", true);
        }
        else if (Input.GetButtonUp("attack1"))
        {
            animator.SetBool("isattack", false);
        }
    }

    void FixedUpdate ()
    {
        controller1.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        loc1 = rb.position;
        vel = rb.velocity;
        if(vel.y < 0)
            animator.SetBool("isjump", false);

        //animator.SetBool("isjump", false);
    }
}
