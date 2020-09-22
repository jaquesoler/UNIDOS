using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOnTrigger : MonoBehaviour
{
    public float vel;

    public float distance;
    
    private Transform target;

    //private Animator boxAnimator;
    
    private Vector2 boxFollow;

    public GameObject player;

    public bool isTouched;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        //boxAnimator = FindObjectOfType<Animator>();
        
    }

    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTouched = true;
        }

    } 


    void Update()
    {

        if (isTouched) {

            boxFollow.x = Input.GetAxisRaw("Horizontal");
            boxFollow.y = Input.GetAxisRaw("Vertical");

            if (Vector2.Distance(transform.position, target.position) > distance) {
                transform.position = Vector2.MoveTowards(transform.position, target.position, vel * Time.deltaTime);

                //boxAnimator.SetInteger("Ghost_Horizontal", (int)ghostMovement.x);
                //boxAnimator.SetInteger("Ghost_Vertical", (int)ghostMovement.y);
            }

        }
    }
}
