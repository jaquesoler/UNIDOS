using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
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
   


    void Start()
    {
        target = Player.GetComponent<Transform>();
        entTarget = Ent.GetComponent<Transform>();
    }

    void Update()
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

        if (Player.GetComponent<EntCollision>().entCollision == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, entTarget.position, vel * Time.deltaTime);
        }
    }

}
