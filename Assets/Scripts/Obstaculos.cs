using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{

    public float velocidade = 5;
    public float posicaoMinima = 3.5f;
    public float posicaoMaxima = 5.5f;
    private float alturaDosObstaculos;

    private void Start()
    {
        PosicionarObstaculos();
    }

    private void PosicionarObstaculos()
    {
        alturaDosObstaculos = Random.Range(posicaoMinima, posicaoMaxima);
        transform.GetChild(0).transform.position = new Vector2(0, -alturaDosObstaculos);
        transform.GetChild(1).transform.position = new Vector2(0, alturaDosObstaculos);
    }

    // Update is called once per frame
    void Update()
    {
        MoverObstaculos();
    }

    private void MoverObstaculos()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
    }
}
