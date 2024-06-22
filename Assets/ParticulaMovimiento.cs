using UnityEngine;


public class ParticulaMovimiento : MonoBehaviour
{
    
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    private void OnTriggerStay2D(Collider2D collision)
    {
        var heading = collision.gameObject.transform.position - this.transform.position;
        var distance = heading.magnitude;
        var direction = heading / distance; // This is now the normalized direction.

        if (collision.GetComponent<CargaElectrica>() != null)
            
            rb.AddForce(direction * CoulombForce(collision.GetComponent<CargaElectrica>().valorCargaElectrica, distance));
    }

    float CoulombForce(float Carga, float Distancia)
    {
        
        return ((Carga * -GetComponent<CargaElectrica>().valorCargaElectrica * 9 * Mathf.Pow(10, 9)) / Mathf.Pow(Distancia, 2));
    
    }
}
