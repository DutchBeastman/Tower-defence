using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {
	//privates



	private Rect windowRect = new Rect(20, 20, 300, 50);//300
	private bool doWindow0 = false;
	private bool doWindow1 = false;
	private Rect windowRect0 = new Rect(20, 20, 140, 80);//370
	private Rect windowRect1 = new Rect(20, 100, 140, 80);//370


	//Start making Buttons
	void Start(){

	}
	void Update(){
		if (Input.GetButtonDown("Fire2")){
			doWindow0 = false;
			doWindow1 = false;
		}
	}


	void OnMouseDown(){

		doWindow0 = true;
		doWindow1 = true;
	}
	void OnGUI() {


		if(doWindow0){
				GUI.Window(0, new Rect(110, 10, 200, 60), DoWindow0, "Basic Window");//200
				GUI.color = Color.red;
				windowRect0 = GUI.Window(0, windowRect0, DoWindow0, "Red Window");
		}
		if(doWindow1){	
				GUI.Window(1, new Rect(110, 10, 200, 90), DoWindow1, "Basic Window");
				GUI.color = Color.green;
				windowRect1 = GUI.Window(1, windowRect1, DoWindow1, "Green Window");
		}
		}
	void DoWindow0(int windowID) {
		if (GUI.Button(new Rect(10, 20, 120, 23), "Tower upgrade 1")){
			
			print("Shiny colors: " + GUI.color);
		}
	}
	void DoWindow1(int windowID) {
		if (GUI.Button(new Rect(10, 20, 120, 23), "Tower upgrade 1")){
			
			print("Shiny colors: " + GUI.color);
		}
	}
	}

