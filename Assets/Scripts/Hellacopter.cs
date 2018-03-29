using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellacopter : MonoBehaviour
{
    private Rigidbody2D rb;
    public float alturaDoPulo = 10;
    public float forcaDoFreio = -5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.AddForce(Vector2.up * alturaDoPulo, ForceMode2D.Impulse);
        }
        else if (Input.GetButtonDown("Fire2"))
        {
            rb.AddForce(Vector2.up * forcaDoFreio, ForceMode2D.Impulse);
        }

    }
}
