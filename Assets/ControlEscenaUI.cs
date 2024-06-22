using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscenaUI : MonoBehaviour
{
    // Start is called before the first frame update
public void ReiniciarEscena()
    {
        SceneManager.LoadScene(0);
    }
}
