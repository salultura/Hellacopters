using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDoJogo : MonoBehaviour {

    private Hellacopter hellacopter;

    private void Awake()
    {
        hellacopter = FindObjectOfType<Hellacopter>();
    }

    private void Update()
    {
        if (hellacopter.Colidiu)
        {
            FimDeJogo();
        }
    }


    void FimDeJogo()
    {
        Time.timeScale = 0;
    }
}
