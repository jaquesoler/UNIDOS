using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterForTransitionAnimals : MonoBehaviour
{

    public GameObject endme;

    public int contador;
   
    void Start()
    {
        contador = 0;  
    }


    void Update()
    {
        if (contador == 7)
        {
            Debug.Log("Você achou Todos, Parabéns!");
            endme.GetComponent<EndStage>().Finish();


            //Aqui entra o codigo pra transição de cena
        }
    }
}
