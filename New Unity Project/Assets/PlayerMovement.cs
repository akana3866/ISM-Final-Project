using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public float jump;
    float moveVelocity;

    bool grounded = true;
    public Animator Anim;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
                rb.velocity = new Vector2(rb.velocity.x, jump);
            Anim.SetInteger("Anim", 2);
        }
        moveVelocity = 0;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
            this.gameObject.transform.localScale = new Vector2(-1, 1);
            Anim.SetInteger("Anim", 1);
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = speed;
            this.gameObject.transform.localScale = new Vector2(1, 1);
            Anim.SetInteger("Anim", 1);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        Anim.SetInteger("Anim", 0);
        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
            grounded = true;
        Anim.SetInteger("Anim", 0);
    }
    private void OnTriggerEnterExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
            grounded = false;
    }

}
