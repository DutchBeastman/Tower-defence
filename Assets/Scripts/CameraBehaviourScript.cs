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

		if(Input.GetKeyDown(KeyCode.A))
		{
			//target.GetComponent(target);
			//transform.LookAt(target);
			//transform.Translate(Vector3.right * Time.deltaTime);
		}
	}


}
