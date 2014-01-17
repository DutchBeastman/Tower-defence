using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour {
	public static int candy;
	public GUIText candyCounter;
	public float nativeWidth = 1024.0f;
	public float nativeHeight = 768.0f;
	public GUIStyle stylos;
	// Use this for initialization
	public void Start () {
		candy = 200;
		StartCoroutine(Timer());
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine(Timer());
		candy.ToString();

	}
	void OnGUI() {
		float rx = Screen.width / nativeWidth;
		float ry = Screen.height / nativeHeight;
		GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1));
		GUI.Label(new Rect(530, 1000, 100, 20), "Candy: " + candy,stylos);
		//candyCounter.text = "Candy: " + candy;



	}

	IEnumerator Timer()
	{
		yield return new WaitForSeconds(0.5f);
		candy += 1;

		StartCoroutine(Timer());

	}
}