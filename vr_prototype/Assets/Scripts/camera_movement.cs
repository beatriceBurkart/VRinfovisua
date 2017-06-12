using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			float yPos = transform.position.y + 1f;
			transform.position = new Vector3 (0, yPos, 0);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			float yPos = transform.position.y - 1f;
			transform.position = new Vector3 (0, yPos, 0);
		}
	}

	public void CameraPositionUp () {
			float yPos = transform.position.y + 1f;
			transform.position = new Vector3(0, yPos, 0);
		}

	public void CameraPositionDown () {
			float yPos = transform.position.y - 1f;
			transform.position = new Vector3(0, yPos, 0);
		}
}