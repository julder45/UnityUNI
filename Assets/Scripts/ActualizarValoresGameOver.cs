﻿using UnityEngine;
using System.Collections;

public class ActualizarValoresGameOver : MonoBehaviour {

	public TextMesh total;
	public TextMesh record;
	public Puntuacion puntuacion;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable(){
		total.text = puntuacion.puntuacion.ToString ();
		record.text = EstadoJuego.estadoJuego.puntuacionMaxima.ToString ();
	}
}
