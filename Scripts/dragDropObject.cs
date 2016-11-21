using UnityEngine;
using System.Collections;

public class dragDropObject : MonoBehaviour,dragDropObjectHandler {
	private bool isHeld;
	private GameObject reticle;
	// Use this for initialization
	void Start () {
		isHeld = false;
		reticle = GameObject.Find ("modifiedReticle");
	}
	
	// Update is called once per frame
	void Update () {
		if (isHeld) {
			Ray ray = new Ray (reticle.transform.position, reticle.transform.forward);
			transform.position = ray.GetPoint (4);
		}
	}

	public void handleTriggerStart (){
		isHeld = true;
	}
	public void handleTriggerEnd(){
		isHeld = false;
	}

}
