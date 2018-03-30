using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public float velocidade = 2;
    private Vector3 posicaoInicial;
    private float larguraRealDaImagem;

    private void Awake()
    {
        posicaoInicial = transform.position;
        float escalaImagem = transform.localScale.x;
        float larguraOriginalDaImagem = GetComponent<SpriteRenderer>().size.x;
        larguraRealDaImagem = escalaImagem * larguraOriginalDaImagem;
    }

    void Update()
    {
        if(larguraRealDaImagem < Mathf.Abs(transform.position.x - posicaoInicial.x))
        {
            transform.position = posicaoInicial;
        }

        transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }
}
