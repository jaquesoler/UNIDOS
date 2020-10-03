using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class FadeInFadeOut : MonoBehaviour
{
    public GameObject dialogue;
    public Image fadeImg;
    public /*Text*/TMP_Text text;
    public /*Text*/TMP_Text textEN;
    public /*Text*/TMP_Text textES;

    public bool fIn;
    public int urucurea;
    public GameObject corujitas;
    // Start is called before the first frame update
    void Start()
    {
        if (fIn == true){
            
        }
        if (fIn == false){
            dialogue.SetActive(true);
            urucurea = 1;

            fadeImg.canvasRenderer.SetAlpha(1.0f);
            text.canvasRenderer.SetAlpha(1.0f);

            fadeImg.CrossFadeAlpha(0,12,false);
            text.CrossFadeAlpha(0,12,false);
            textEN.CrossFadeAlpha(0,12,false);
            textES.CrossFadeAlpha(0,12,false);

            
            
        }  
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(10);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        dialogue.SetActive(false);
    }

    IEnumerator UrucureaCoroutine(){
        Debug.Log("Started Coroutineaaa at timestamp : " + Time.time);
        yield return new WaitForSeconds(8);                
        corujitas.SetActive(true);
    }

    // Update is called once per frame
    public void fade()
    {
            dialogue.SetActive(true);

            fadeImg.canvasRenderer.SetAlpha(0.0f);
            text.canvasRenderer.SetAlpha(0.0f);
            textEN.canvasRenderer.SetAlpha(0.0f);
            textES.canvasRenderer.SetAlpha(0.0f);

            fadeImg.CrossFadeAlpha(1,8,false);
            text.CrossFadeAlpha(1,8,false);
            textEN.CrossFadeAlpha(1,8,false);
            textES.CrossFadeAlpha(1,8,false);

            if(urucurea == 1){
                Debug.Log("aaaaa");
                StartCoroutine(UrucureaCoroutine());
            }

    }
}
