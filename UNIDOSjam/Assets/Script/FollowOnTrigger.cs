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
    public GameObject Spawner;
    private Transform target;
    private Transform entTarget;
    private Vector2 boxFollow;
    public bool triggered;
    public bool delivered;
    void Start()
    {
        this.GetComponent<RotateAroundEntity>().enabled = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        Ent = GameObject.FindGameObjectWithTag("Ent");
        Spawner = GameObject.FindGameObjectWithTag("ManagerSpawn");

        target = Player.GetComponent<Transform>();
        entTarget = Ent.GetComponent<Transform>();
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
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            this.GetComponent<MoveDownwards>().enabled = false;
            this.triggered = true;


        }
        if (col.tag == "Ent")
        {
            this.GetComponent<RotateAroundEntity>().enabled = true;
            Spawner.GetComponent<SpawnManager>().FlowersSpawned++;
            // Som florzinha entregue
            this.GetComponent<FollowOnTrigger>().enabled = false;

        }
    }

}
