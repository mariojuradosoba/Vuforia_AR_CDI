using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textController : MonoBehaviour {


	private GameObject textoHidrogeno;
	private GameObject textoOxigeno;
	private GameObject textoCarbono;
	private GameObject textoSodio;
	private GameObject textoNitrogeno;
	private GameObject textoCloro;


	public bool showTexto = false;


	// Use this for initialization
	void Start () {

		textoHidrogeno = GameObject.Find ("textoHidrogeno");
		textoOxigeno = GameObject.Find ("textoOxigeno");
		textoCarbono = GameObject.Find ("textoCarbono");
		textoSodio = GameObject.Find ("textoSodio");
		textoNitrogeno = GameObject.Find ("textoNitrogeno");
		textoCloro = GameObject.Find ("textoCloro");



	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.I)) {
			showTexto = !showTexto;
		}



		setTexto ();

	}

	private void setTexto (){

		textoHidrogeno.SetActive (showTexto);
		textoOxigeno.SetActive (showTexto);
		textoCarbono.SetActive (showTexto);
		textoSodio.SetActive (showTexto);
		textoNitrogeno.SetActive (showTexto);
		textoCloro.SetActive (showTexto);

	}


}
