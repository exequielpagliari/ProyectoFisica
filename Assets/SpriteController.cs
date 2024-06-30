using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    [SerializeField] List<Sprite> spriteList = new List<Sprite> (); 
    [SerializeField] List<BoxCollider2D> boxColliderList = new List<BoxCollider2D> (); 
    private Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    
    BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        
    }
    void Update()
    {
        if(rb.mass < 60 )
        {
            spriteRenderer.sprite = spriteList[0];
            boxCollider = boxColliderList[0];
        }
        else if(rb.mass < 250)
        {
            spriteRenderer.sprite = spriteList[1];
            boxCollider = boxColliderList[1];
        }
        else if(rb.mass < 1000)
        {
            spriteRenderer.sprite = spriteList[2];
            boxCollider = boxColliderList[2];
        }
        else if(rb.mass < 2500)
        {
            spriteRenderer.sprite = spriteList[3];
            boxCollider = boxColliderList[3];
        }
        else
        {
            spriteRenderer.sprite = spriteList[4];
            boxCollider = boxColliderList[4];
        }
    }
}
