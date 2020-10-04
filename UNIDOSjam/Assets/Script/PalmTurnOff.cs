using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalmTurnOff : MonoBehaviour
{
    private PalmeiraPuzzle _palmeiraPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        _palmeiraPuzzle = FindObjectOfType(typeof(PalmeiraPuzzle)) as PalmeiraPuzzle;
        //_palmeiraPuzzle.isNeedTurnOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
