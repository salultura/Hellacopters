using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculosController : MonoBehaviour {

    public float velocidade = 5;
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);		
	} 
}
