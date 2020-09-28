using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float deliveredTimer;
    public Rigidbody2D playerRb;
    private Vector2 movement;
    public bool entCollision = false;
    public bool colisao = false;
    public bool delivered = false;
    


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
            transform.rotation = Quaternion.Euler(0, 0, -90);

        }
        else if (movement.x < -0.05f)
        {
            transform.rotation = Quaternion.Euler(0, 180, -90);

        }
    }

    void MovementAction()
    {
        playerRb.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }

    IEnumerator OnTriggerEnter2D (Collider2D target)
    {
        if (target.tag == "Flower")
        {
            colisao = true;
            entCollision = false;
        } 
        else if (target.tag == "Ent") 
        {
            if (colisao == true){
                colisao = false;
                entCollision = true;
                delivered = true;
            }           
        }

        if (delivered == true)
        {
            yield return new WaitForSeconds(deliveredTimer);
            entCollision = false;
            delivered = false;
        }

    }

}