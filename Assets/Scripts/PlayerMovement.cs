using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float playerJumpHeight = 7.0f;
    [SerializeField] public Rigidbody2D playerRb;
    public float xAxis;
    public Vector3 PlayerPos;
    private bool PlayerGrounded = true;
    private void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        Move();
        Jump();
        PlayerPos = playerRb.position;
    }


    private void Move()
    {
        playerRb.velocity = new Vector2(xAxis * playerSpeed, playerRb.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && PlayerGrounded == true)
        {
            playerRb.velocity = new Vector2(playerRb.velocity.x, playerJumpHeight);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        PlayerGrounded = false;
    }
}
