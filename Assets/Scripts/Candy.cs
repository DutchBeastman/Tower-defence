using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {
	public static int candy = 200;
	public GUIText candyCounter;

	// Use this for initialization
	public void Start () {
		StartCoroutine(Timer());
	}
	
	// Update is called once per frame
	void Update () {
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