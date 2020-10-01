using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    Vector3 originalPos;
    GameObject player;

    void Awake(){
        player = GameObject.FindGameObjectWithTag("Player"); 
        originalPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = originalPos;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        player.transform.position = originalPos;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
