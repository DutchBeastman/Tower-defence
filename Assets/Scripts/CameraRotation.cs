using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	bool rotatingLeft = false;
	bool rotatingRight = false;

	void Update () {
		/////Rotating Left & Right
		switch(rotatingLeft){
			case true:
				transform.Rotate(0, 2, 0);
			break;
		}
		switch(rotatingRight){
			case true:
				transform.Rotate(0, -2, 0);
			break;
		}
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
	}
}
