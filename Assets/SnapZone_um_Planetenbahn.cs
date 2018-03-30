using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class SnapZone_um_Planetenbahn : MonoBehaviour {

	public Vector3 posleft;
	public Vector3 posright;
	public float Distanceri;
	public float Distancele;
	private Vector3 center; 
	
	// Update is called once per frame
	void Update () {

		GameObject left = GameObject.Find ("LeftHand");
		posleft = left.GetComponent<PositionLeftHand> ().positionleft;


		GameObject right = GameObject.Find ("RightHand");
		posright = right.GetComponent<PositionRightHand> ().positionright;

		Distanceri = Vector3.Distance (posright,center);
		Debug.Log (Distanceri);

		Distancele = Vector3.Distance (posleft,center);
		Debug.Log (Distancele);
		
	}
}
