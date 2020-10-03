using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitBeforeAnimation : MonoBehaviour
{
    public GameObject container;
    public GameObject livro;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UrucureaCoroutine());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator UrucureaCoroutine(){
        Debug.Log("Started Coroutineaaa at timestamp : " + Time.time);
        yield return new WaitForSeconds(19);                
        container.SetActive(false);
        livro.SetActive(true);
        Camera.main.GetComponent<Animator>().enabled = true;
    }
}
