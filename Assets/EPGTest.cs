using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EPGTest : MonoBehaviour
{
    private Transform primeraPosicion;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Slider masaSlider;
    [SerializeField] Slider alturaSlider;
    [SerializeField] Text epgValor;
    [SerializeField] Text masaValorText;
    [SerializeField] Text alturaValorText;
    [SerializeField] Transform subibaja;
    private float alturaEPG;
    // Start is called before the first frame update
    void Start()
    {
        alturaValorText.text = alturaSlider.value.ToString();
        masaValorText.text = masaSlider.value.ToString();
        alturaValorText.text = (rb.gameObject.transform.position.y - subibaja.transform.position.y).ToString();
        primeraPosicion = rb.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (masaSlider.value == 0)
        {
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0;
        }
        else
            rb.gravityScale = 1;

        epgValor.text = CalcularEPG().ToString();
            
    }

    public void ChangeAltura(float sliderValue)
    {
        rb.velocity = Vector2.zero;
        rb.gameObject.transform.position = new Vector2(primeraPosicion.position.x, sliderValue);
        alturaValorText.text = (rb.gameObject.transform.position.y - subibaja.transform.position.y).ToString();
    }

    public void ChangeMass(float value)
    {
        rb.mass = value;
        masaValorText.text = value.ToString();
        alturaEPG = rb.gameObject.transform.position.y - subibaja.transform.position.y;
    }


    void CambiarAltura(float altura)
    {
        rb.velocity = Vector2.zero;
        rb.gameObject.transform.position = new Vector2(primeraPosicion.position.x, primeraPosicion.position.y + altura);
        
    }

    float CalcularEPG()
    {
        return masaSlider.value * alturaEPG * 9.8f;
    }
}
