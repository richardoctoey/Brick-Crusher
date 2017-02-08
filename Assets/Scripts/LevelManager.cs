using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	private int numBricks;

	public void Start(){
		numBricks = GameObject.FindGameObjectsWithTag ("Brick").Length;
	}

	public void Update(){
		if (numBricks <= 0){
			Application.LoadLevel ("Win");
		}
	}

	public void LoadLevel(string name){
		Application.LoadLevel (name);
	}
	
	public void QuitRequest(string name){
		Application.Quit ();
	}
	
	public void LoadNextLevel(){
		Application.LoadLevel (Application.loadedLevel + 1);
	}
}
