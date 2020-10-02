using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterForTransitionAnimals : MonoBehaviour
{

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
            this.GetComponent<EndStage>().EndLvl();


            //Aqui entra o codigo pra transição de cena
        }
    }
}
