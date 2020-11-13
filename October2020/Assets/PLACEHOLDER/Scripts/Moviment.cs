using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    private Vector2 Direction;
    private Rigidbody2D rb;
    public AudioSource jumpy;

    private bool CanJump = true;

    private float realSpeed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        realSpeed = Speed/100;
    }

    
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") > 0) {
            transform.Translate(Vector2.right*realSpeed);
        }

        if(Input.GetAxisRaw("Horizontal") < 0) {
            transform.Translate(Vector2.left*realSpeed);
        }

        
        
        if(Input.GetKeyDown(KeyCode.UpArrow) && CanJump) {
            rb.velocity = Vector2.up*JumpForce;
            jumpy.Play();
            CanJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Floor")) {
            CanJump = true;
        }
    }
}
