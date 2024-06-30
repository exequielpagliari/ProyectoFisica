using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

[System.Serializable] public struct cordenadas
{
    [SerializeField] public float x;
    [SerializeField] public float y;
};


public class SpriteController : MonoBehaviour
{


    [SerializeField] List<Sprite>   spriteList = new List<Sprite> (); 
    [SerializeField] List<cordenadas>   xyPositionCollider = new List<cordenadas> ();
    [SerializeField] List<cordenadas>   xyOffsetCollider = new List<cordenadas> ();
    private Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    
    BoxCollider2D boxCollider;




    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        SetCollider(0);
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }



    void Update()
    {
        if(rb.mass < 60 )
        {
            //1.28x 3.6y
            //0.05x 1.39y offset
            
            spriteRenderer.sprite = spriteList[0];
            SetCollider(0);
        }
        else if(rb.mass < 250)
        {
            //1.4x 3.6y
            //0.05x 1.25y offset
            spriteRenderer.sprite = spriteList[1];
            SetCollider(1);
            
        }
        else if(rb.mass < 1000)
        {
            //2x 3.6y
            //0.05x 1.26y offset

            spriteRenderer.sprite = spriteList[2];
            SetCollider(2);
        }
        else if(rb.mass < 2500)
        {
            //2.81x 3.6y
            //0.05x 1.26y offset
            spriteRenderer.sprite = spriteList[3];
            SetCollider(3);
        }
        else
        {
            //3.91x 3.6
            //0.05x 0.84y offset
            spriteRenderer.sprite = spriteList[4];
            SetCollider(4);
        }
    }

    void SetCollider(int collider)
    {
        boxCollider.size = new Vector2(xyPositionCollider[collider].x, xyPositionCollider[collider].y);
        boxCollider.offset = new Vector2(xyOffsetCollider[collider].x, xyOffsetCollider[collider].y); 
    }
}
