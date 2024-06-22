using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuenteElectrica : MonoBehaviour
{
    [Range(0f, 220f)]
    public float tension;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() != null)
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * tension);
    }
}
