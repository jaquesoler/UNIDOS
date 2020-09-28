using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSpawnManager : MonoBehaviour
{

    public int flowDelivered;

    void Start()
    {
        flowDelivered = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (flowDelivered >= 10)
        {
            GameObject.Find("SpawnManager").SetActive(false);
        }
    }

    
}
