using UnityEngine;
using System.Collections;

public class StartButtonScript : MonoBehaviour {
	public GameObject candySetter;
	void OnMouseDown(){
		Application.LoadLevel("LVL1");
	}
}
