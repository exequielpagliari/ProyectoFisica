using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarSuperCarga : MonoBehaviour
{
    [SerializeField] GameObject SuperCarga;

    public void Activar()
    { 
        if(!SuperCarga.activeSelf)
        SuperCarga.SetActive(true);
        else
        SuperCarga.SetActive(false);
    }
}
