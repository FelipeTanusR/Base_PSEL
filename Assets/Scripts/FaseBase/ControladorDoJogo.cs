using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDoJogo : MonoBehaviour
{
    //Pega o Canvas da UI de morte
    [SerializeField] GameObject Canvas;

    public void Morreu()
    {
        //Para o tempo e ativa o Canvas
        Canvas.gameObject.SetActive(true);

        Time.timeScale = 0.0f;
    }
}
