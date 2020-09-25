using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntCollision : MonoBehaviour
{
    public GameObject Player;
    public bool entCollision = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Player.GetComponent<Movement>().colisao = false;
        entCollision = true;
    }
}
