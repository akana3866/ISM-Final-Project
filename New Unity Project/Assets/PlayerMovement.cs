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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (grounded)
                rb.velocity = new Vector2(rb.velocity.x, jump);
        }
        moveVelocity = 0;

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        rb.velocity = new Vector2(moveVelocty.rb.velocty.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
            grounded = true;
    }
    private void OnTriggerEnterExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
            grounded = false;
    }

}
