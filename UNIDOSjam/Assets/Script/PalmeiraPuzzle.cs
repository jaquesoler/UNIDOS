﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PalmeiraPuzzle : MonoBehaviour
{ 
public int[] puzzle1;
public int[] puzzleAnswer;
public int sequencePuzzle;

public bool isNeedTurnOn1;
public bool isNeedTurnOn2;
public bool isNeedTurnOn3;
public bool isNeedTurnOn4;
public bool isNeedTurnOn5;
   

public AudioClip[] audios;
public AudioSource audioSource;

public GameObject[] lightPalm;

    public Button[] palmButtons;

public bool turnOnButtons;

public GameObject endme;

public GameObject fadeCanvas;

    // Start is called before the first frame update
    void Start()
{
        //
        StartCoroutine(JackoCoroutine());
    /*for (int i = 0; i <= 4; i++ )
      {
          puzzle1[i] = i;
          Debug.Log(puzzle1[i]);
      }*/


}

  IEnumerator JackoCoroutine(){
        Debug.Log("Started Coroutineaaa at timestamp : " + Time.time);
        yield return new WaitForSeconds(20);
        fadeCanvas.SetActive(false);
        StartCoroutine("StartPalmsPuzzle");          
    }

// Update is called once per frame
void Update()
{
        if (turnOnButtons)
        {
            foreach (Button palmbut in palmButtons)
            {
                palmbut.interactable = true;
            }
        }

        if(sequencePuzzle == 5)
        {
            Debug.Log("Você venceu o puzzle");
            PuzzleController.isDone4 = true;
            
            endme.GetComponent<EndStage>().Finish();
            sequencePuzzle = 0;
        }

        
}

public void InputPuzzle(int valorPuzzle)
{
    if (sequencePuzzle >= puzzleAnswer.Length)
    {
        sequencePuzzle = 0;
    }

    puzzleAnswer[sequencePuzzle] = valorPuzzle;

    audioSource.PlayOneShot(audios[valorPuzzle - 1]);

    if (puzzleAnswer[sequencePuzzle] == puzzle1[sequencePuzzle])
    {
        Debug.Log("Deu certo");
        sequencePuzzle++;           
    }
    else
    {
        sequencePuzzle = 0;
            foreach (GameObject light in lightPalm)
            {
                light.SetActive(false);
                isNeedTurnOn1 = false;
                isNeedTurnOn2 = false;
                isNeedTurnOn3 = false;
                isNeedTurnOn4 = false;
                isNeedTurnOn5 = false;
            }
            StartCoroutine("StartPalmsPuzzle");
        }


}

    IEnumerator StartPalmsPuzzle()
    {

        foreach(Button palmbutton in palmButtons)
        {
            palmbutton.interactable = false;
        }


        foreach(GameObject light in lightPalm)
        {
            light.SetActive(true);
        }
        yield return new WaitForSeconds(0.5f);

        foreach (GameObject light in lightPalm)
        {
            light.SetActive(false);
        }
        yield return new WaitForSeconds(0.5f);

        foreach (GameObject light in lightPalm)
        {
            light.SetActive(true);
        }
        yield return new WaitForSeconds(0.5f);

        foreach (GameObject light in lightPalm)
        {
            light.SetActive(false);
        }

        yield return new WaitForSeconds(1);
        isNeedTurnOn1 = true;
        isNeedTurnOn2 = true;
        isNeedTurnOn3 = true;
        isNeedTurnOn4 = true;
        isNeedTurnOn5 = true;

       
    }

}

