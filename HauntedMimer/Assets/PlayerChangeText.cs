using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerChangeText : MonoBehaviour {
	public TextTrigger[] textTriggers;
	public Text mainUIText;
	public FollowPath followP;
	// Use this for initialization
	void Start () {
		textTriggers = GameObject.FindObjectsOfType<TextTrigger>();
		Text[] allTexts = GameObject.FindObjectsOfType<Text>();
		for(var i = 0 ; i < allTexts.Length ; i++){
			if (allTexts [i].tag == "MainUIText")
				mainUIText = allTexts [i];
		}
		FollowPath[] allPaths = GameObject.FindObjectsOfType<FollowPath>();
		for(var i = 0 ; i < allPaths.Length ; i++){
			if (allPaths [i].tag == "Player")
				followP = allPaths [i];
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "TextTrigger") {
			for (var i = 0; i < textTriggers.Length; i++){
				if (col.gameObject == textTriggers [i].gameObject) {
					mainUIText.text = textTriggers [i].textToEdit;
					followP.Speed = textTriggers [i].speed;
					mainUIText.color = Color.white;
				}
			}
		}
	}

}