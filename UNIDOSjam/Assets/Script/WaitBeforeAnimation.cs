using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitBeforeAnimation : MonoBehaviour
{
    public GameObject container;
    public GameObject livro;

    public GameObject fadeOut;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UrucureaCoroutine());
        StartCoroutine(TransitCoroutine());
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

    IEnumerator TransitCoroutine(){
        Debug.Log("Started Coroutineaaa at timestamp : " + Time.time);
        yield return new WaitForSeconds(22);                
        fadeOut.GetComponent<FadeInFadeOut>().fade();
        AudioManager.Instance.gameObject.GetComponent<AudioSource>().Pause();

        StartCoroutine(ChangeSceneCoroutine());
    }

    IEnumerator ChangeSceneCoroutine(){
        
        yield return new WaitForSeconds(8);                
        SceneManager.LoadScene("Final");
    }
}
