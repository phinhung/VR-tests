using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Snap : MonoBehaviour {

	Vector3 posleft;
	Vector3 posright;
	Vector3 center;
	bool objectisgrabbed;
	float Distanceri;
	float Distancele;
	public float alloweddistance;
	public GameObject ju;
	public bool allowsnap;	


	// Update is called once per frame
	void Update () {
		
		GameObject left = GameObject.Find ("LeftController");
		posleft = left.GetComponent<PositionLeftHand> ().positionleft;


		GameObject right = GameObject.Find ("RightController");
		posright = right.GetComponent<PositionRightHand> ().positionright;


	//	 ju = GameObject.Find("Jupiter");
		var jugrabbed = ju.GetComponentInParent<VRTK_InteractableObject> ();
		objectisgrabbed = jugrabbed.IsGrabbed ();

		if (objectisgrabbed == true) {
			Distanceri = Vector3.Distance (posright, center);
		//	Debug.Log (Distanceri);

			Distancele = Vector3.Distance (posleft, center);
		//	Debug.Log (Distancele);
			if (allowsnap == true){
				Debug.Log (Distanceri);
				Debug.Log (Distancele);
				if (objectisgrabbed == true && (Distancele < alloweddistance | Distanceri < alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = false;
					GetComponent<SphereCollider>().enabled = false;
					Debug.Log ("no");
				}
				if (objectisgrabbed == true && (Distancele > alloweddistance | Distanceri > alloweddistance)) {
					GetComponent<VRTK_SnapDropZone>().enabled = true;
					GetComponent<SphereCollider>().enabled = true;
					//GetComponent<VRTK_SnapDropZone> ().ForceSnap (ju);
					Debug.Log ("yes");

				}
			}
		}
		
	}

	public void goSnap(){
		//SnapZoneScript = GameObject.GetComponent<VRTK_SnapDropZone>(); //.GetComponent<VRTK_SnapDropZone> ();
	
	//	SnapZoneScript.ForceSnap ();
	}
	public void distance(){
		
			allowsnap = true;
	 
	}
}
