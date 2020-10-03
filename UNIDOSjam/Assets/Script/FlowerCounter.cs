using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerCounter : MonoBehaviour
{

    public int flowDelivered;

    public GameObject endme;
    public GameObject music;

    void Start()
    {
        flowDelivered = 0;
        StartCoroutine(MyCoroutine());

    }

    IEnumerator MyCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(20);

        //After we have waited 5 seconds print the time again.
        this.GetComponent<SpawnManager>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {   Debug.Log(flowDelivered);
        if (flowDelivered >= 8)
        {
            //Debug.Log("Iamandu ta Happyy!");
            endme.GetComponent<EndStage>().triggerMeTimbers = true;
            music.SetActive(true);
        }

        else if (flowDelivered < 8 && this.GetComponent<SpawnManager>().FlowersSpawned >= this.GetComponent<SpawnManager>().SpawnRepeater)
        {
            Debug.Log("Iamandu ta Tisti...");

        }
    }

    
}
