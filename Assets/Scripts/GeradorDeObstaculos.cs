using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {
    [SerializeField] private GameObject obstaculo;
    [SerializeField] private float intervaloParaCriacao = 3;
    private float tempoDaUltimaCriacao;

    void Start () {
        Instantiate(obstaculo, transform.position, Quaternion.identity);
        tempoDaUltimaCriacao = Time.time;
        
    }
	
	void Update ()
    {
        GerarObstaculo();
    }

    private void GerarObstaculo()
    {
        if (Time.time > tempoDaUltimaCriacao + intervaloParaCriacao)
        {
            Instantiate(obstaculo, transform.position, Quaternion.identity);
            tempoDaUltimaCriacao += intervaloParaCriacao;
        }
    }
}
