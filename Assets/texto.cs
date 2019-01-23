using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class texto : MonoBehaviour {

	private int veces;
	public Text textoAMostrar;

	// Use this for initialization
	void Start () {
		veces = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void sumarPresion() {
		veces++;
		textoAMostrar.text = "Veces presionado: " + veces;
	}
}
