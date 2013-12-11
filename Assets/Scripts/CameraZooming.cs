using UnityEngine;
using System.Collections;

public class CameraZooming : MonoBehaviour {
	
	bool zoomIn = false;
	bool zoomOut = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(zoomIn){
			transform.position.z -= 0.2f;
		}
		if(zoomOut){
			transform.position.z += 0.2f;
		}

		if(Input.GetKeyDown(KeyCode.D))
		{
			zoomIn = true;
		}
		if(Input.GetKeyUp(KeyCode.D))
		{
			zoomIn = false;
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			zoomOut = true;
		}
		if(Input.GetKeyUp(KeyCode.S))
		{
			zoomOut = false;
		}
	}
}
