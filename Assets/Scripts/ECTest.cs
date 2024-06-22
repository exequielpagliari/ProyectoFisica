using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ECTest : MonoBehaviour
{
    [SerializeField] float velocidadValor;
    [SerializeField] float masaValor;
    [SerializeField] Slider velocidadSlider;
    [SerializeField] Slider masaSlider;
    [SerializeField] Text velocidadText;
    [SerializeField] Text masaText;
    [SerializeField] Text ecText;

    [SerializeField] bool direccion;
    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb.mass = masaSlider.value;
        rb.velocity = Vector2.right * velocidadSlider.value * DetectarDireccion(direccion);
    }

    // Update is called once per frame
    void Update()
    {
        
        velocidadText.text = velocidadSlider.value.ToString();
        masaText.text = masaSlider.value.ToString();
        rb.mass = masaSlider.value;
        if (masaSlider.value == 0)
            rb.velocity = Vector2.zero;
        else
        rb.velocity = Vector2.right * velocidadSlider.value * DetectarDireccion(direccion);
        ecText.text = ObtenerValorEC(masaSlider.value, velocidadSlider.value).ToString();

    }

    int DetectarDireccion(bool direccion)
    {
        if (direccion)
        {
            return 1;
        }
        else
        {
            return -1;
        }

    }

    float ObtenerValorEC(float masa, float velocidad)
    {
        
        
        return 0.5f * masa * velocidad * velocidad;
    }
}
