using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PuzzleSelectPhase : MonoBehaviour
{
    public int numberPuzzle;
    
    // Start is called before the first frame update
    void Start()
    {
        if (numberPuzzle == 1)
        {
            if (PuzzleController.isDone1)
            {
                Destroy(this.gameObject);
            }
        }
        else if (numberPuzzle ==2)
        {
            if (PuzzleController.isDone2)
            {
                Destroy(this.gameObject);
            }
        }
        else if (numberPuzzle == 3)
        {
            if (PuzzleController.isDone3)
            {
                Destroy(this.gameObject);
            }
        }
        else if (numberPuzzle == 4)
        {
            if (PuzzleController.isDone4)
            {
                Destroy(this.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
}
