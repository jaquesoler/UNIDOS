using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeedDestroy : MonoBehaviour
{
    public string namePhase;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PuzzleController.ligarNeblina = false;
            SceneManager.LoadScene(namePhase);
        }
    }
}
