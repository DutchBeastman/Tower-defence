<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {
	public int candy;
	// Use this for initialization
	void Start () {
	
=======
using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {
	public static int candy = 200;
	public GUIText candyCounter;

	// Use this for initialization
	public void Start () {
		StartCoroutine(Timer());
>>>>>>> 402568e90102675915f2385d67a40078f5343dbb
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
	
	}
}
=======
		//StartCoroutine(Timer());
		candy.ToString();

	}
	void OnGUI() {
		//candy = GUI.TextField(new Rect(10, 10, 200, 20),"Candy:" + candy, 25);
		candyCounter.text = "Candy: " + candy;



	}

	IEnumerator Timer()
	{
		yield return new WaitForSeconds(0.5f);
		candy += 1;

		StartCoroutine(Timer());

	}
}
>>>>>>> 402568e90102675915f2385d67a40078f5343dbb
