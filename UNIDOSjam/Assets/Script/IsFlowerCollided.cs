using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsFlowerCollided : MonoBehaviour
{

    public bool flowCollided;
    public GameObject Manager;

    void Start()
    {
        flowCollided = false;
        Manager = GameObject.FindGameObjectWithTag("ManagerSpawn");
    }

    private void Update()
    {
        Score();

       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Ent")
        {
            flowCollided = true;
        }
    }

    void Score() 
    { 
        if (flowCollided) 
        { 
            Manager.GetComponent<FlowerCounter>().flowDelivered += 1;
            flowCollided = false;
        }
    }
}
