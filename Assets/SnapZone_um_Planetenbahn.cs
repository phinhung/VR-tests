using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class SnapZone_um_Planetenbahn : MonoBehaviour {

	public Vector3 posleft;
	public Vector3 posright;
	
	// Update is called once per frame
	void Update () {

		GameObject left = GameObject.Find ("LeftHand");
		posleft = left.GetComponent<PositionLeftHand> ().positionleft;


		GameObject right = GameObject.Find ("RightHand");
		posright = right.GetComponent<PositionRightHand> ().positionright;
		
	}
}
