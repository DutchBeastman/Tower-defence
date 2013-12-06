using UnityEngine;
using System.Collections;

public class CameraBehaviourScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)
		{
			target Transform;
			transform.LookAt(target);
			transform.Translate(Vector3.right * Time.deltaTime);
		}
	}


}
