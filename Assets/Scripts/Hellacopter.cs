using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hellacopter : MonoBehaviour
{
    private Rigidbody2D rb;
    public float alturaDoPulo = 10;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            this.rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * alturaDoPulo, ForceMode2D.Impulse);
        }
    }
}
