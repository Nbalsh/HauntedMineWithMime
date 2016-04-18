using UnityEngine;
using System.Collections;

public class BatTrigger : MonoBehaviour {
	//public BatFinalMove script;
	public BatFinalMove[] scripts;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		// play a sound needed
		foreach(BatFinalMove scr in scripts){
			scr.BatStart ();
		}
	}
}
