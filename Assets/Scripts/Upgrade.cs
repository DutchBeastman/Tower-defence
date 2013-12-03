using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {
	//public
	public Rect windowRect = new Rect(20, 20, 120, 50);
	public bool doWindow0 = true;
	public bool doWindow1 = true;
	public Rect windowRect0 = new Rect(20, 20, 170, 80);
	public Rect windowRect1 = new Rect(20, 100, 170, 80);
	//Start making Buttons
	void OnGUI() {
		doWindow0 = GUI.Toggle(new Rect(10, 10, 120, 30), doWindow0, "Window 0");
		doWindow1 = GUI.Toggle(new Rect(10, 40, 100, 20), doWindow1, "Window 1");
			if (doWindow0)
			{
				GUI.Window(0, new Rect(110, 10, 200, 60), DoWindow0, "Basic Window");
				GUI.color = Color.red;
				windowRect0 = GUI.Window(0, windowRect0, DoMyWindow, "Red Window");

			}
			if (doWindow1){
				GUI.Window(0, new Rect(110, 10, 200, 60), DoWindow1, "Basic Window");
				GUI.color = Color.green;
				windowRect1 = GUI.Window(1, windowRect1, DoMyWindow, "Green Window");
			}
		}
	void DoWindow0(int windowID) {
		GUI.Button(new Rect(10, 30, 80, 20), "Do this and that!");
	}
	void DoWindow1(int windowID) {
		GUI.Button(new Rect(10, 30, 80, 20), "Do that and this!");
	}


	void DoMyWindow(int windowID) {
		if (GUI.Button(new Rect(20, 25, 160, 23), "Tower upgrade 1")){

			print("Shiny colors: " + GUI.color);
		}
		GUI.DragWindow(new Rect(0, 0, 10000, 10000));
		
	}
}
