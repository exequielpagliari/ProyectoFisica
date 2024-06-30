using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    [SerializeField] List<Sprite> spriteList = new List<Sprite> (); 
    private Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    
    BoxCollider2D boxCollider;




    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();

        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }



    void Update()
    {
        if(rb.mass < 60 )
        {
            //1.45x 1.1y
            spriteRenderer.sprite = spriteList[0];
            boxCollider.size = new Vector2(1.45f,1.1f); 
        }
        else if(rb.mass < 250)
        {
            //1.63x 1.14y
            boxCollider.size = new Vector2(1.63f,1.4f); 
            
        }
        else if(rb.mass < 1000)
        {
            //2.12x 1.23y
            spriteRenderer.sprite = spriteList[2];
            boxCollider.size = new Vector2(2.12f,1.23f); 
        }
        else if(rb.mass < 2500)
        {
            //3.16x 1.34y
            spriteRenderer.sprite = spriteList[3];
            boxCollider.size = new Vector2(3.16f,1.34f); 
        }
        else
        {
            //4.3x 2.1y
            spriteRenderer.sprite = spriteList[4];
            boxCollider.size = new Vector2(4.3f,2.1f); 
        }
    }
}
