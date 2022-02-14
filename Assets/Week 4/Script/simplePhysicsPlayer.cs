using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))] // say what component you require for the script to have and adds the component for you.
[RequireComponent(typeof(Rigidbody2D))]

public class simplePhysicsPlayer : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField]
    float jumpStrength = 5.0f;
    [SerializeField]
    float movementSpeed = 5.0f;
    float moveX;

    bool canJump = false;
    bool isGrounded = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void PlayerControls()
    {
        moveX = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
        }
    }

    void Jump()
    {
        if (!isGrounded)
            return;

        isGrounded = false;
       
        rb.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
        Debug.Log("JUMP!", gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        Debug.Log("Hit something", collision.gameObject);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * movementSpeed, rb.velocity.y);

        if(canJump == true)
        {
            canJump = false;
            Jump();
        }
    }

    private void Update()
    {
        PlayerControls();
    }
}
