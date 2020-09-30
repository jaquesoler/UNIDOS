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
    // Start is called before the first frame update
    void Start()
    {
        if (fIn == true){
            
        }
        if (fIn == false){
            dialogue.SetActive(true);

            fadeImg.canvasRenderer.SetAlpha(1.0f);
            text.canvasRenderer.SetAlpha(1.0f);

            fadeImg.CrossFadeAlpha(0,5,false);
            text.CrossFadeAlpha(0,5,false);
            textEN.CrossFadeAlpha(0,8,false);
            textES.CrossFadeAlpha(0,8,false);
        }  
    }

    // Update is called once per frame
    public void fade()
    {
        if (fIn == true){
            dialogue.SetActive(true);

            fadeImg.canvasRenderer.SetAlpha(0.0f);
            text.canvasRenderer.SetAlpha(0.0f);

            fadeImg.CrossFadeAlpha(1,2,false);
            text.CrossFadeAlpha(1,2,false);
        }

    }
}
