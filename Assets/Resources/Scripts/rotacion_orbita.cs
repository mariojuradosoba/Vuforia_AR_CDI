using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion_orbita : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.left * Time.deltaTime * 20);

	}
}
