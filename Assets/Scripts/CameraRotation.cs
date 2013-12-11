using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	bool rotatingLeft = false;
	bool rotatingRight = false;
	bool zoomIn = false;
	bool zoomOut = false;/*
	Vector3 normalScale;
	Vector3 biggerScale;
	Vector3 SmallerScale;*/
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		/*normalScale = transform.position;
		biggerScale = transform.position;
		SmallerScale = transform.position;
		biggerScale.z += 0.2f;
		SmallerScale.z -= 0.2f;
		*/
		if(rotatingLeft){
			transform.Rotate(0, 2, 0);
		}
		if(rotatingRight){
			transform.Rotate(0, -2, 0);
		}
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
