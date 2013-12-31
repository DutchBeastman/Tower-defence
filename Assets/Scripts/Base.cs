using UnityEngine;
using System.Collections;

public class Base : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == "Enemy11" ||col.gameObject.name == "Enemy12" ||col.gameObject.name == "Enemy2" ||col.gameObject.name == "Enemy31" ||col.gameObject.name == "Enemy32")
		{

		}
	}
}
