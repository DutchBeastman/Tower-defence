using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {
	//public

	private Rect windowRect = new Rect(20, 20, 300, 50);//300
	private bool doWindow0 = true;
	private bool doWindow1 = true;
	private Rect windowRect0 = new Rect(20, 20, 140, 80);//370
	private Rect windowRect1 = new Rect(20, 100, 140, 80);//370
	//Start making Buttons
	void OnGUI() {
		doWindow0 = GUI.Toggle(new Rect(10, 10, 200, 30), doWindow0, "Window 0");//200
		doWindow1 = GUI.Toggle(new Rect(10, 40, 100, 20), doWindow1, "Window 1");//100
			if (doWindow0)
			{
				GUI.Window(0, new Rect(110, 10, 200, 60), DoWindow0, "Basic Window");//200
				GUI.color = Color.red;
				windowRect0 = GUI.Window(0, windowRect0, DoMyWindow, "Red Window");

			}
			if (doWindow1){
				//GUI.Window(1, new Rect(110, 10, 800, 600), DoWindow0, "yolo");
				GUI.Window(1, new Rect(110, 10, 200, 90), DoWindow1, "Basic Window");
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
		if (GUI.Button(new Rect(10, 20, 120, 23), "Tower upgrade 1")){

			print("Shiny colors: " + GUI.color);
		}
		GUI.DragWindow(new Rect(0, 0, 10000, 10000));
		
	}
}
