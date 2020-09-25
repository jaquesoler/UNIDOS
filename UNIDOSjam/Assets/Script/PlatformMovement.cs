using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public int health;
    public float speed;
    public float jumpForce;
    private float moveInput;
    private Rigidbody2D rb;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpsValue;

    //private Animator anim;

    void Start(){
        extraJumps = extraJumpsValue;
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    //use for ingame physics
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        if(moveInput == 0){
            //anim.SetBool("isRunning", false);
        } else{
            //anim.SetBool("isRunning", true);

        }
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        Debug.Log(facingRight);
        
        //if moving right and not facing the right direction
        if (moveInput < 0){
            transform.eulerAngles = new Vector3(0, 180, 0);//Flip();
        } else if(moveInput > 0){
            transform.eulerAngles = new Vector3(0, 0, 0);//Flip();
        }
    }

    void Update(){

        if(isGrounded == true){
            extraJumps = extraJumpsValue;
            //anim.SetBool("isJumping", false);
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && extraJumps > 0){
            //anim.SetBool("isJumping", true);
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        } else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJumps == 0 && isGrounded == true){
            //anim.SetBool("isJumping", true);
            rb.velocity = Vector2.up * jumpForce;
        }
        
        if(health <= 0){
            Destroy(gameObject);
        }
    }

    void Flip(){
        facingRight = !facingRight;
        Vector3 Scaler = transform.eulerAngles;
        Scaler.x *= -1;
        transform.eulerAngles = Scaler;
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(groundCheck.position, checkRadius);
    }

    public void TakeDamage(int damage){
        //Instantiate(bloodEffect, transform.position, Quaternion.identity);
        health -= damage;
        Debug.Log("damaged player");
    }
}
