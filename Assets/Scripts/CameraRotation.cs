using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	public bool rotatingLeft = false;
	public bool rotatingRight = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

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
