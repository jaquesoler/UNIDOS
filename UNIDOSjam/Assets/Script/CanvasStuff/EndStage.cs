using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndStage : MonoBehaviour
{
    public string scene;
    public GameObject fade;

    void Start(){
            
    }

    void OnTriggerEnter2D(Collider2D col){
        fade.GetComponent<FadeInFadeOut>().fade();
        //SceneManager.LoadScene(scene);
    }
}
