using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class StartButtonScript : MonoBehaviour {
	public GameObject candySetter;
	public AudioClip Intro;
	void Start(){
		audio.PlayOneShot(Intro, 1F);
	}
	void OnMouseDown(){
		Application.LoadLevel("LVL1");


	}
}
