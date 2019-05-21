using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nivel1 : MonoBehaviour {



	public float radius = 2.22f;
	
	void Update () {

		var segments = 360;
		var pointCount = segments + 1;
		var points = new Vector3[pointCount];

		for (int i = 0; i < pointCount; i++) {
			var rad = Mathf.Deg2Rad * (i * 360f / segments);
			points [i] = new Vector3 (0,Mathf.Sin (rad) * radius, Mathf.Cos (rad) * radius);
		}
		GetComponent<LineRenderer> ().positionCount = segments + 1;
		GetComponent<LineRenderer> ().SetPositions (points);
		GetComponent<LineRenderer> ().startWidth = 0.06f;
		GetComponent<LineRenderer> ().useWorldSpace = false;

	}
}
