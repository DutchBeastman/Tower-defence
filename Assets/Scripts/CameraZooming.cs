using UnityEngine;
using System.Collections;

public class CameraZooming : MonoBehaviour {

	bool zoomIn = false;
	bool zoomOut = false;
	Vector3 biggerCamPos;
	Vector3 smallerCamPos;
	void Start(){
		biggerCamPos = new Vector3(transform.position.x,transform.position.y,transform.position.z+0.2f);
		smallerCamPos = new Vector3(transform.position.x,transform.position.y,transform.position.z-0.2f);
	}
	void Update () {

		biggerCamPos = transform.position;

		if(zoomIn){
			transform.position = smallerCamPos;
		}
		if(zoomOut){
			transform.position = biggerCamPos;
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
