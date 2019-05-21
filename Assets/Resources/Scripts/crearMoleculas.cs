using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearMoleculas : MonoBehaviour
{

	public GameObject hidrogeno;
	public GameObject carbono;
	public GameObject nitrogeno;
	public GameObject oxigeno;
	public GameObject sodio;
	public GameObject cloro;

	public GameObject prefabAgua;
	public GameObject prefabMonoxidoDeCarbono;
	public GameObject prefabMetano;
	public GameObject prefabAmoniaco;
	public GameObject prefabSal;


	private GameObject agua;
	private GameObject monoxidoDeCarbono;
	private GameObject metano;
	private GameObject amoniaco;
	private GameObject sal;

	private void initMoleculas(){
		 agua =(GameObject) Instantiate (prefabAgua, new Vector3 (0f, 0f, 0f), new Quaternion (0f, 0f, 0f, 0f));
		 monoxidoDeCarbono =Instantiate (prefabMonoxidoDeCarbono, new Vector3 (0f, 0f, 0f), new Quaternion (0f, 0f, 0f, 0f));
		 metano =Instantiate (prefabMetano, new Vector3 (0f, 0f, 0f), new Quaternion (0f, 0f, 0f, 0f));
		 amoniaco =Instantiate (prefabAmoniaco, new Vector3 (0f, 0f, 0f), new Quaternion (0f, 0f, 0f, 0f));
		 sal =Instantiate (prefabSal, new Vector3 (0f, 0f, 0f), new Quaternion (0f, 0f, 0f, 0f));

		agua.SetActive (false);
		monoxidoDeCarbono.SetActive (false);
		metano.SetActive (false);
		amoniaco.SetActive (false);
		sal.SetActive (false);

	}

	void Start(){
		initMoleculas();
	}

	public bool info  = false;

	void Update ()
	{


		comprueba (hidrogeno, carbono, metano);
		comprueba (sodio, cloro, sal);
		comprueba (hidrogeno, oxigeno, agua);
		comprueba (nitrogeno, hidrogeno, amoniaco);
		comprueba (carbono, oxigeno, monoxidoDeCarbono);


		if (Input.GetKeyDown (KeyCode.I)) {
			info = !info;
		}


	}
	private void actualizaPos(GameObject a1, GameObject a2, GameObject mol){
		var position = new Vector3 ((a1.GetComponent<Transform> ().position.x + a2.GetComponent<Transform> ().position.x) / 2, 
			               0f, 
			               (a1.GetComponent<Transform> ().position.z + a2.GetComponent<Transform> ().position.z) / 2);

		mol.GetComponent<Transform> ().SetPositionAndRotation (position, new Quaternion (0f, 0f, 0f, 0f));

	}


	private void comprueba (GameObject atomo1, GameObject atomo2, GameObject molecula){

		if (Mathf.Abs (atomo1.GetComponent<Transform> ().position.x - atomo2.GetComponent<Transform> ().position.x ) < 7.5) {
			atomo1.SetActive (false);
			atomo2.SetActive (false);
			molecula.SetActive (true);

			if (info == true) {
				molecula.transform.GetChild (0).gameObject.SetActive(true);
			} else {
				molecula.transform.GetChild (0).gameObject.SetActive(false);
			}

			//TextMesh textoAgua =  new TextMesh ();
			//textoAgua.text = "asdadaasdasdad";
			//textoAgua.transform.parent = molecula.transform;
			//textoAgua.GetComponent<Transform> ().SetPositionAndRotation (new Vector3 (0f, 0f, 0f), new Quaternion (0f, 0f, 0f, 0f));

			actualizaPos (atomo1, atomo2, molecula);

		} else {
			if (!atomo1.activeInHierarchy && !atomo2.activeInHierarchy){
			atomo1.SetActive (true);
			atomo2.SetActive (true);
			molecula.SetActive (false);
		}
	}


}
}


