using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D playerRb;
    private Vector2 movement;
    public bool colisao = false;

    void Start()
    {
      
    }

    void Update()
    {
        Controller();

    }

    private void FixedUpdate()
    {
        MovementAction();
    }

    
    void Controller()
    {
        movement.x = Input.GetAxisRaw("Horizontal");

        movement.y = Input.GetAxisRaw("Vertical");

        if (movement.x > 0.05f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);

        }
        else if (movement.x < -0.05f)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

        }
    }

    void MovementAction()
    {
        playerRb.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }

    void OnTriggerEnter2D (Collider2D collider)
    {
        colisao = true;
    }
    
   
}
