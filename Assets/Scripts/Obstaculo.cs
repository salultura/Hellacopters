using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{

    [SerializeField] private float velocidade = 5;
    [SerializeField] private float posicaoMinima = -3;
    [SerializeField] private float posicaoMaxima = 0;
    private float sorteiaPosicaoEmY;

    private void Awake()
    {
        PosicionarObstaculo();
    }

    private void PosicionarObstaculo()
    {
        sorteiaPosicaoEmY = Random.Range(posicaoMinima, posicaoMaxima);
        transform.position = new Vector3(transform.position.x, sorteiaPosicaoEmY, 0.0f);
    }

    void Update()
    {
        MoverObstaculo();
    }

    private void MoverObstaculo()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ForaDaTela"))
        {
            AutoDestruir();
        }
        
    }

    private void AutoDestruir()
    {
        Destroy(gameObject);
    }
}
