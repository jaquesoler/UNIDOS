using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteAnimal : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    void Start()
    {
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
                ChangeSprite();
            }
            
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
