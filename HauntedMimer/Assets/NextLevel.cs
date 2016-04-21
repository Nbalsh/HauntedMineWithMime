using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider col){
		if(col.gameObject.tag == "NextLevel"){
			GoToNextLevel nxtLevel = GameObject.FindObjectOfType<GoToNextLevel> ();
			SceneManager.LoadScene (nxtLevel.LevelToGoTo);
		}
	}
}
