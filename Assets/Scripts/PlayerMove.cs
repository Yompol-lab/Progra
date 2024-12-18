using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumPSpeed = 3;

    Rigidbody2D rb2D;

    public SpriteRenderer spriteRenderer;

    public Animator animator;       

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

   
    void FixedUpdate()
    {
        if  (Input.GetKey("d")) 
        {
            rb2D.velocity = new Vector2(runSpeed,rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }
        else if (Input.GetKey("a")) 
        {
            rb2D.velocity = new Vector2(-runSpeed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
        }
        else 
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);

        }
        if (Input.GetKeyDown("space") && CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumPSpeed);
        }
        if (CheckGround.isGrounded == false) 
        {
            animator.SetBool("Jump", true) ;
            animator.SetBool("Run", false) ;

        }
        if (CheckGround.isGrounded == true) 
        {
            animator.SetBool("Jump", false);
            animator.SetBool("Falling", false);

        }    
        if (rb2D.velocity.y<0f) 
        {
            animator.SetBool("Falling", true);
        }
        else if (rb2D.velocity.y > 0f)
        {
            animator.SetBool("Falling", false);
        }


    }
}
