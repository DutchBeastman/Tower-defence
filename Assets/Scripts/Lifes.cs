using UnityEngine;
using System.Collections;

public class Lifes : MonoBehaviour {
	public static int lifes;
	public GUIText lifeCounter;
	public float nativeWidth = 1024.0f;
	public float nativeHeight = 768.0f;
	public GUIStyle stylos;
	// Update is called once per frame
	void Start () {
		lifes = 50;
		StartCoroutine(UpdatingCounter());
	}
	void OnGUI() {
		float rx = Screen.width / nativeWidth;
		float ry = Screen.height / nativeHeight;
		GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1));
		GUI.Label(new Rect(650, 10, 100, 20), "Lifes: " + lifes,stylos);
		//candyCounter.text = "Candy: " + candy;
	}
	
	IEnumerator UpdatingCounter()
	{
		yield return new WaitForSeconds(0.5f);
		lifes.ToString();
		
		StartCoroutine(UpdatingCounter());
		
	}
	public void LifeTaken(int hit){
		lifes -= hit;
		Debug.Log(lifes);
		if(lifes <= 0)
		{
			Application.LoadLevel("Dead");
		}
	}
}
