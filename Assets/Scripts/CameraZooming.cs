using UnityEngine;
using System.Collections;

public class CameraZooming : MonoBehaviour {
	bool zoomIn = false;
	bool zoomOut = false;
	public float minMaxZoom = 1;
	
	void Update () {

		///////Zooming In & Out
		switch(zoomIn){
			case true:
			if(minMaxZoom >= 0)
				{
					transform.Translate(0, 0, 2);
					minMaxZoom -= 0.1f;
				}
			break;
		}
		switch(zoomOut){
			case true:
				if(minMaxZoom <= 2)
				{
					transform.Translate(0, 0, -2);
					minMaxZoom += 0.1f;
				}
			break;
		}

		/////////S & W
		if(Input.GetKeyDown(KeyCode.W))

		{
			zoomIn = true;
		}
		if(Input.GetKeyUp(KeyCode.W))
		{
			zoomIn = false;
		}
		if(Input.GetKeyDown(KeyCode.S))
		{
			zoomOut = true;
		}
		if(Input.GetKeyUp(KeyCode.S))
		{
			zoomOut = false;
		}
		
		if(Input.GetKeyDown(KeyCode.N))
		{
			Application.LoadLevel("Dead");
		}
	}
}

