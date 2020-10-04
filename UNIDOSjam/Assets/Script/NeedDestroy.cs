using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeedDestroy : MonoBehaviour
{
    public string namePhase;
    public GameObject nuvensDissolviveis;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            nuvensDissolviveis.SetActive(false);
            SceneManager.LoadScene(namePhase);
        }
    }
}
