using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteAnimal : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public AudioSource clique;
    public GameObject Contador;

    void Start()
    {
        Contador = GameObject.FindGameObjectWithTag("contador");

        clique = GetComponent<AudioSource>();
        
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            BoxCollider2D col = this.GetComponent<BoxCollider2D>();
            
            if (col.OverlapPoint(wp))
            {
                clique.Play();
                ChangeSprite();
                Contador.GetComponent<CounterForTransitionAnimals>().contador+=1;
                this.GetComponent<ChangeSpriteAnimal>().enabled = false;

            }
            
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
