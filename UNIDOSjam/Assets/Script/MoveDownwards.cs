﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDownwards : MonoBehaviour
{
    public float speed = 10f;
    public float EndZone = -22f;
    public GameObject Spawner;

    private void Start()
    {
        Spawner = GameObject.FindGameObjectWithTag("ManagerSpawn");
    }

    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);

        if (transform.position.y < EndZone)
        {
            Dissapear();
            Spawner.GetComponent<SpawnManager>().FlowersSpawned++;

        }
    }


    void Dissapear()
    {
        Destroy(this.gameObject);
    }

}
