﻿using UnityEngine;
using System.Collections;

public class WaveCounter : MonoBehaviour {
	public float nativeWidth = 1024.0f;
	public float nativeHeight = 768.0f;
	public GUIStyle stylos;

	void OnGUI() {
			float rx = Screen.width / nativeWidth;
			float ry = Screen.height / nativeHeight;
			GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1));
			GUI.Label(new Rect(600, 10, 100, 20), " Wave: " + WaveSpawner.waves,stylos);
	}
}