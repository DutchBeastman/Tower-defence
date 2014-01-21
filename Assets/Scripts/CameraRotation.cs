using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	bool rotatingLeft = false;
	bool rotatingRight = false;
	float speed;
	float minMaxVar;

	void Update () {
		//minMaxVar = GetComponent<CameraZooming>().minMaxZoom;
		speed = 3;

		/////////A & D
		if(Input.GetKeyDown(KeyCode.A))
		{
			rotatingLeft = true;
		}
		if(Input.GetKeyUp(KeyCode.A))
		{
			rotatingLeft = false;
		}
		if(Input.GetKeyDown(KeyCode.D))
		{
			rotatingRight = true;
		}
		if(Input.GetKeyUp(KeyCode.D))
		{
			rotatingRight = false;
		}

		/////Rotating Left & Right
		if (rotatingLeft){
			transform.Rotate(0, speed, 0);
		}
		if(rotatingRight){
			transform.Rotate(0, -speed, 0);
		}
	}
}
