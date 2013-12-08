using UnityEngine;
using System.Collections;

public class CameraBehaviourScript : MonoBehaviour {
	//public
	public Transform target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray))
			{

			}
		if(Input.GetKeyDown(KeyCode.A))
		{
			target.transform;
			transform.LookAt(target);
			transform.Translate(Vector3.right * Time.deltaTime);
		}
	}


}
