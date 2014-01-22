using UnityEngine;
using System.Collections;

public class WaveTekst : MonoBehaviour {
	public float nativeWidth = 1024.0f;
	public float nativeHeight = 768.0f;
	public GUIStyle stylos;
	public static string WaveName = System.String.Empty;
	public static bool check = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(check){
			StartCoroutine(WaveCheck());
			check = false;
		}
	}
	void OnGUI() {
		float rx = Screen.width / nativeWidth;
		float ry = Screen.height / nativeHeight;
		GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1));
		GUI.Label(new Rect(40, 250, 100, 20), WaveName,stylos);
	}
	IEnumerator WaveCheck(){

			yield return new WaitForSeconds(1);
			WaveName = System.String.Empty;
	}
}