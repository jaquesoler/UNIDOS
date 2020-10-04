using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalmLight : MonoBehaviour
{
    public GameObject palmLight;

    public float timeToTurnOn;
    public float timeToTurnOff;
    private PalmeiraPuzzle _palmeiraPuzzle;
    public int thisPalmNumber;
    // Start is called before the first frame update
    void Start()
    {
        _palmeiraPuzzle = FindObjectOfType(typeof(PalmeiraPuzzle)) as PalmeiraPuzzle;   
    }

    // Update is called once per frame
    void Update()
    {
        if(thisPalmNumber == 1)
        {
            if (_palmeiraPuzzle.isNeedTurnOn1 == true)
            {
                StartCoroutine("TurnOnLight");
            }
        }
        else if(thisPalmNumber == 2)
        {
            if (_palmeiraPuzzle.isNeedTurnOn2 == true)
            {
                StartCoroutine("TurnOnLight");
            }
        }
        else if( thisPalmNumber == 3)
        {
            if (_palmeiraPuzzle.isNeedTurnOn3 == true)
            {
                StartCoroutine("TurnOnLight");
            }
        }
        else if(thisPalmNumber == 4)
        {
            if (_palmeiraPuzzle.isNeedTurnOn4 == true)
            {
                StartCoroutine("TurnOnLight");
            }
        }
        else if(thisPalmNumber == 5)
        {
            if (_palmeiraPuzzle.isNeedTurnOn5 == true)
            {
                StartCoroutine("TurnOnLight");
            }
        }

    }

    IEnumerator TurnOnLight()
    {
        yield return new WaitForSeconds(timeToTurnOn);
        if(thisPalmNumber == 1)
        {
            if (_palmeiraPuzzle.isNeedTurnOn1 == true)
            {
                _palmeiraPuzzle.isNeedTurnOn1 = false;
                palmLight.SetActive(true);

                _palmeiraPuzzle.audioSource.PlayOneShot(_palmeiraPuzzle.audios[0]);

                yield return new WaitForSeconds(timeToTurnOff);
                palmLight.SetActive(false);
            }

        }
        else if(thisPalmNumber == 2)
        {
            if (_palmeiraPuzzle.isNeedTurnOn2 == true)
            {
                _palmeiraPuzzle.isNeedTurnOn2 = false;
                palmLight.SetActive(true);

                _palmeiraPuzzle.audioSource.PlayOneShot(_palmeiraPuzzle.audios[1]);

                yield return new WaitForSeconds(timeToTurnOff);
                palmLight.SetActive(false);
            }

        }
        else if (thisPalmNumber == 3)
        {
            if (_palmeiraPuzzle.isNeedTurnOn3 == true)
            {
                _palmeiraPuzzle.isNeedTurnOn3 = false;
                palmLight.SetActive(true);

                _palmeiraPuzzle.audioSource.PlayOneShot(_palmeiraPuzzle.audios[2]);

                yield return new WaitForSeconds(timeToTurnOff);
                palmLight.SetActive(false);
            }

        }
        else if (thisPalmNumber == 4)
        {
            if (_palmeiraPuzzle.isNeedTurnOn4 == true)
            {
                _palmeiraPuzzle.isNeedTurnOn4 = false;
                palmLight.SetActive(true);

                _palmeiraPuzzle.audioSource.PlayOneShot(_palmeiraPuzzle.audios[3]);

                yield return new WaitForSeconds(timeToTurnOff);
                palmLight.SetActive(false);
            }

        }
        else if (thisPalmNumber == 5)
        {
            if (_palmeiraPuzzle.isNeedTurnOn5 == true)
            {
                _palmeiraPuzzle.isNeedTurnOn5 = false;
                palmLight.SetActive(true);

                _palmeiraPuzzle.audioSource.PlayOneShot(_palmeiraPuzzle.audios[4]);

                yield return new WaitForSeconds(timeToTurnOff);
                palmLight.SetActive(false);
                _palmeiraPuzzle.turnOnButtons = true;
            }

        }


    }
}
