using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellacopter : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool colidiu = false;
    [SerializeField] private float alturaDoPulo = 3;
    private Vector3 posicaoInicial;

    public bool Colidiu
    {
        get
        {
            return colidiu;
        }

        private set
        {
            colidiu = value;
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        posicaoInicial = new Vector3(-4, 2, 0);
        PosicionarHellacopter();
    }

    private void FixedUpdate()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            this.rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * alturaDoPulo, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("colidiu");
        Colisao();
    }

    private void Colisao()
    {
        rb.simulated = false;
        Colidiu = true;
    }

    private void PosicionarHellacopter()
    {
        transform.position = posicaoInicial;
    }
}
