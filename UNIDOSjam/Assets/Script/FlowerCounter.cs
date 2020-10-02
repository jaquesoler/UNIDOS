using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCounter : MonoBehaviour
{

    public int flowDelivered;

    void Start()
    {
        flowDelivered = 0;
    }

    // Update is called once per frame
    void Update()
    {   Debug.Log(flowDelivered);
        if (flowDelivered >= 8)
        {
            //Debug.Log("Iamandu ta Happyy!");
            GetComponent<EndStage>().EndLvl();
        }

        else if (flowDelivered < 8 && this.GetComponent<SpawnManager>().FlowersSpawned >= this.GetComponent<SpawnManager>().SpawnRepeater)
        {
            Debug.Log("Iamandu ta Tisti...");

        }
    }

    
}
