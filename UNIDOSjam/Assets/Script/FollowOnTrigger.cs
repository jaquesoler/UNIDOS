using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
//using System.Security.Cryptography;
using UnityEngine;

public class FollowOnTrigger : MonoBehaviour
{
    public float vel;
    public float distance;
    public GameObject Player;
    public GameObject Ent;
    private Transform target;
    private Transform entTarget;
    private Vector2 boxFollow;
    public bool triggered;
    public bool delivered;
    public bool dissapear;
    private float disTimer;
    public bool flowCollided;
   


    void Start()
    {
        this.GetComponent<RotateAroundEntity>().enabled = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        Ent = GameObject.FindGameObjectWithTag("Ent");

        target = Player.GetComponent<Transform>();
        entTarget = Ent.GetComponent<Transform>();

        disTimer = 4.0f;
        dissapear = true;

        flowCollided = false;
    }

    void Update()
    {
        if(triggered)
        {
            if ( Player.GetComponent<Movement>().colisao == true)
            {
                boxFollow.x = Input.GetAxisRaw("Horizontal");
                boxFollow.y = Input.GetAxisRaw("Vertical");

                if (Vector2.Distance(transform.position, target.position) > distance)
                {
                    transform.position = Vector2.MoveTowards(transform.position, target.position, vel * Time.deltaTime);

                }
            }
            else if (Player.GetComponent<Movement>().entCollision == true)
            {
                transform.position = Vector2.MoveTowards(transform.position, entTarget.position, vel * Time.deltaTime);
            }
        }
        else        
        {

            disTimer -= Time.deltaTime;

            if (dissapear == true && disTimer <= 0)
            {
                Dissapear();
            }
        }


    }

    void Dissapear()
    {
        Destroy(this.gameObject);
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Player"){
            this.dissapear = false;
            this.triggered = true;
        }
         if (col.tag == "Ent"){
            this.GetComponent<RotateAroundEntity>().enabled = true;
            this.GetComponent<FollowOnTrigger>().enabled = false;
         }
    }

}