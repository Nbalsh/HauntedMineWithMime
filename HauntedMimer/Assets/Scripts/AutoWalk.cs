using UnityEngine;
using System.Collections;

public class AutoWalk : MonoBehaviour 
{
	private CardboardHead head;
	private Cardboard cardboard;
	public float speed = 7;

	void Start () 
	{
		head = Camera.main.GetComponent<StereoController>().Head;
		cardboard = head.GetComponentInParent<Cardboard> ();
	}

	void Update () 
	{
		// example for how to see if something is triggered
		if (cardboard.Triggered) {

		}
		// for aiming where head is aiming
		Vector3 direction = new Vector3(head.transform.forward.x, 0, head.transform.forward.z).normalized * speed * Time.deltaTime;
		Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
		transform.Translate(rotation * direction);
		// move
		transform.position = new Vector3(transform.position.x, 1, transform.position.z);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Wall") {
			// hit wall, go back to middle
			Debug.Log("Smacked a wall");
			gameObject.transform.position = new Vector3 (0, 1, 0);
		}
	}

}