using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDirection : MonoBehaviour
{
    public enum Direction // *
    {
        Arriba,
        Abajo,
        Derecha,
        Izquierda,
    }
    public Direction direction;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (direction == Direction.Arriba)
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.up;
        if (direction == Direction.Abajo)
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.down;
        if (direction == Direction.Derecha)
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.right;
        if (direction == Direction.Izquierda)
            collision.GetComponent<Rigidbody2D>().velocity = Vector2.left;
    }
}
