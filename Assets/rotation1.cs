using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class rotation1 : MonoBehaviour {

	public GameObject Bahn; //Planetenbahn
	public float speed; //Rotationsgeschwindigkeit
	Vector3 center;


	void RotationPlaneten(){

		transform.RotateAround (Bahn.transform.position, Vector3.up, speed * Time.deltaTime); //Rotieren des Planeten
	}
	void Rotation(){

		transform.RotateAround (center, Vector3.up, speed * Time.deltaTime); //Rotieren des Planeten
	}


	bool isSnappedj;

	
	// Update is called once per frame
	void Update () {

	


			GameObject snapj = GameObject.Find("SnapDropZone");
			isSnappedj = snapj.GetComponent<VRTK_SnapDropZone> ().isSnapped; 

		if (isSnappedj == true)
		{

			RotationPlaneten (); 
			//rotieren, wenn Planet an richtiger Stelle
			}

	}
	}

