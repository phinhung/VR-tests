using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class rotation1 : MonoBehaviour {

	public GameObject Bahn; //Planetenbahn
	public float speed; //Rotationsgeschwindigkeit
	Vector3 center;
	public bool task1finished;


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
			task1finished = true;
			//rotieren, wenn Planet an richtiger Stelle
			}
		if (task1finished==true){
			ModeSelect ();

		}}
		public float delay = 2f;
	public void ModeSelect(){
		StartCoroutine ("Wait");
	}
	IEnumerator Wait(){
		yield return new WaitForSeconds (5);
		NextTask ();
	}
	
		public void LoadNextScene()
		{
			SceneManager.LoadScene ("Planeten", LoadSceneMode.Additive);
		}

		public void NextTask()
		{	
			SceneManager.UnloadScene ("Jupiter");
		LoadNextScene ();
		}

	


		
	
	}




