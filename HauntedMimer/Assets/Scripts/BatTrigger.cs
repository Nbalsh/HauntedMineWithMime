using UnityEngine;
using System.Collections;

public class BatTrigger : MonoBehaviour {
	//public BatFinalMove script;
	public BatFinalMove[] scripts;
	bool once = true;
	public AudioClip batsound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (once == true) {
			AudioSource.PlayClipAtPoint(batsound, other.transform.position);
			foreach (BatFinalMove scr in scripts) {
				scr.BatStart ();
			}
			once = false;
		}
	}
}
