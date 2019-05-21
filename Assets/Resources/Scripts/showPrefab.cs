using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showPrefab : DefaultTrackableEventHandler {

	public GameObject prefab;

	void Start () {


		prefab.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);

		GameObject hijo = Instantiate (prefab, transform.position, prefab.GetComponent<Transform>().rotation);
		hijo.GetComponent<Transform>().SetParent(GetComponent<Transform>());
	}


}
