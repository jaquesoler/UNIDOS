using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigaAsNuvens : MonoBehaviour
{
    public GameObject nuvensDissolviveis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PuzzleController.ligarNeblina == true)
        {
            nuvensDissolviveis.SetActive(true);
        }
        else
        {
            nuvensDissolviveis.SetActive(false);
        }
    }

   
}
