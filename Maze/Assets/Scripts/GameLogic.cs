using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject startUI;
	public GameObject startPoint, playPoint;

	// Use this for initialization
	void Start () {
		//place player at start point, in front of startUI
		player.transform.position = startPoint.transform.position;
	}

	// Update is called once per frame
	void Update () {

	}


	public void playerDropToStart() {
		startUI.SetActive (false);
		iTween.MoveTo (player, playPoint.transform.position, 5f);
	}
		
	public void resetPlayer() {
		iTween.MoveTo (player, 
			iTween.Hash (
				"position", startPoint.transform.position, 
				"time", 4, 
				"easetype", "linear",
				"oncomplete", "resetGame", 
				"oncompletetarget", this.gameObject
			)
		);

	}
}