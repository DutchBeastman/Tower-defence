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
<<<<<<< HEAD
		if(Input.GetKeyDown(KeyCode.A))
		{
			//target Transform;
			//transform.LookAt(target);
			//transform.Translate(Vector3.right * Time.deltaTime);
=======

		if(Input.GetKeyDown(KeyCode.A))
		{
			//target.GetComponent(target);
			transform.LookAt(target);
			transform.Translate(Vector3.right * Time.deltaTime);
>>>>>>> d47da5f0f71e6aff2331d464e4d0be91b0706831
		}
	}


}
