using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.0f;
    public float moveX = 0.0f;
    public float moveY = 0.0f;


    void Start()
    {
      
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        gameObject.transform.position = new Vector2(transform.position.x + (moveX * speed * Time.deltaTime),
            transform.position.y + (moveY * speed * Time.deltaTime));
    }
    
   
}
