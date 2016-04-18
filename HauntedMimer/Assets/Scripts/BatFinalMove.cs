using UnityEngine;
using System.Collections;

public class BatFinalMove : MonoBehaviour {
	public int speed = 80;
	public int spaces = 50;
	// Use this for initialization
	void Start () {
		//float startingZpos = this.transform.position.z;
		//float startingZpos2 = GameObject.FindGameObjectWithTag("Bat").transform.position.z;
		//MoveInvoker ();
		//StartCoroutine("ContinuousMove", startingZpos);
		//StartCoroutine("ContinuousMoveObject", startingZpos2);
		this.gameObject.SetActive(false);
	}
	
	void Update () {
		//this.GetComponent<Transform> ().Translate(0,0,Time.deltaTime * speed * -1);
	}

	// called by the trigger cube
	public void BatStart(){
		this.gameObject.SetActive(true);
		float startingZpos = this.transform.position.z;
		//float startingZpos2 = GameObject.FindGameObjectWithTag("Bat").transform.position.z;
		//MoveInvoker ();
		StartCoroutine("ContinuousMove", startingZpos);
		//StartCoroutine("ContinuousMoveObject", startingZpos2);
	}

	void MoveInvoker(int startingZpos)
	{
		StartCoroutine(ContinuousMove(startingZpos));
	}

	// Used to move the attached object
	IEnumerator ContinuousMove(float z)
	{
		var finalZ = z - spaces;
		while (this.transform.position.z > finalZ) {
			yield return new WaitForSeconds(0F);
			this.GetComponent<Transform> ().Translate(0,0,Time.deltaTime * speed * 1);
			/*z--;
			if (this.transform.position.z == finalZ) {
				this.GetComponent<Renderer> ().enabled = false;
			}*/
		}
		//this.GetComponent<Renderer> ().enabled = true;
		this.gameObject.SetActive(false);
	}

	// used to move all bats
	// not used
	IEnumerator ContinuousMoveObject(float z)
	{
		var finalZ = z - spaces;
		while (GameObject.FindGameObjectWithTag("Bat").transform.position.z > finalZ) {
			yield return new WaitForSeconds(0F);
			var bats = GameObject.FindGameObjectsWithTag("Bat");
			foreach(GameObject bat in bats){
				bat.GetComponent<Transform> ().Translate(0,0,Time.deltaTime * speed * -1);
			}
			/*z--;
			if (this.transform.position.z == finalZ) {
				this.GetComponent<Renderer> ().enabled = false;
			}*/
		}
		var bats2 = GameObject.FindGameObjectsWithTag ("Bat");
		foreach(GameObject bat in bats2){
			bat.GetComponent<Renderer> ().enabled = false;
		}
	}

	// other not used functions
	// not used
	void MoveBatLeft() {

		var x = -1 * Time.deltaTime * speed;
		//rigidbody.AddForce (x);
		this.GetComponent<Transform> ().Translate(x,0,0);
	}

	// not used
	void MoveBatRight() {

		var x = Time.deltaTime * speed;
		//rigidbody.AddForce (x);
		this.GetComponent<Transform> ().Translate(x,0,0);
	}
}
