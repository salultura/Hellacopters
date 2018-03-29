using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    public float velocidade = 2;
    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
        posicaoInicial = transform.position;
        float escalaImagem = transform.localScale.x;
        float tamanhoImagem = GetComponent<SpriteRenderer>().size.x;
        tamanhoRealDaImagem = escalaImagem * tamanhoImagem;
    }

    void Update()
    {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
