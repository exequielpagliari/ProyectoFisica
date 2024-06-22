using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResistenciaEléctrica : MonoBehaviour
{
    [Range(.5f, 5000000f)]
    public float resistencia;
    public int carga;
    public float tiempocarga = 5;
    public float tiempoEspera;
    public float corrienteElectrica;
    public float Tiempo;

    private void Start()
    {
        tiempoEspera = tiempocarga;

        
    }

    private void Update()
    {
        Tiempo = Time.time;
        if (Time.time > tiempoEspera)
        {
            tiempoEspera = Time.time + tiempocarga;
            corrienteElectrica = carga / tiempocarga;
            carga = 0;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        carga += 1;
        if (collision.gameObject.GetComponent<Rigidbody2D>() != null)
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity / resistencia;
    }



}
