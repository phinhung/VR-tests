using VRTK;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public void LoadScenea()
	{
		SceneManager.LoadScene ("Jupiter", LoadSceneMode.Additive);
	}
	void Start(){
		LoadScenea ();
	}

}
