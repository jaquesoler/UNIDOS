using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndStage : MonoBehaviour
{
    public string scene;
    public GameObject fade;
    public bool triggerMeTimbers;

    void OnTriggerEnter2D(Collider2D col){
        if(triggerMeTimbers){
            fade.GetComponent<FadeInFadeOut>().fade();
            triggerMeTimbers = false;
            StartCoroutine(ExampleCoroutine());   
        }
    }

    public void EndLvl(){
        fade.GetComponent<FadeInFadeOut>().fade();
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        SceneManager.LoadScene(scene);
    }
}
