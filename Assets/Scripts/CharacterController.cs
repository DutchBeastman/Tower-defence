using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	public bool standing;
	private CameraController controller;
	private bool jumping;
	private int jumpValue;
	private GameObject playerArt;
	private DragObject drag;
	private Vector3 movementSpeed = new Vector3();
	public bool stopmovement;
	private FadeScript fade;
	private RaycastHit hit;
	public float dist = 0.6f;
	private Vector3 dir;
	private bool leveldone;
	public AudioClip opendoor,pickupsound;
	void Start () {
		fade = GameObject.Find("MainCube").GetComponent<FadeScript>();
		controller = GameObject.Find("MainCube").GetComponent<CameraController>();
		controller.target = transform;
		playerArt = GameObject.Find("Player/Art");
		drag = GameObject.Find("MainCube").GetComponent<DragObject>();
	}

	void FixedUpdate () {
		if(leveldone &fade.alphaFadeValue == 1){
		Application.LoadLevel("Menu");	
		}
		if(jumpValue >= -20){
			jumpValue -= 20;
		}
		if(standing){
			drag.candrag = true;
		}
		else{
			drag.candrag = false;	
		}
		movementSpeed = new Vector3();
		Vector3 oldposition = movementSpeed;
		movementSpeed.y = rigidbody.velocity.y + (jumpValue / 100);	
		if(Input.GetAxis("Horizontal") < 0){
			movementSpeed.x = -2.5f;
		}
		if(Input.GetAxis("Horizontal") > 0){
			movementSpeed.x = 2.5f;
		}
		if(!drag.hasDragObject){
			if(Input.GetAxis("Jump") != 0){
				if(standing){
					jumpValue = 150;
				}
			}
		}
		if(movementSpeed.x < oldposition.x){
			playerArt.renderer.material.mainTextureScale = new Vector2(-1,1);
		}
		if(movementSpeed.x > oldposition.x){
			playerArt.renderer.material.mainTextureScale = new Vector2(1,1);
		}
		rigidbody.velocity = movementSpeed;
	}
	void Update(){
     dir = new Vector3(0,-1,0);
     	if(Physics.Raycast(transform.position,dir,out hit,dist)){
			if(hit.collider.name != "Player"){
				standing = true;
				drag.playerstands = true;
			}
     	}
     	else{
       		standing = false;	
			drag.playerstands = false;
    	}
	}
	void OnTriggerEnter(Collider coll){
		if(coll.collider.name == "PickUp"){
		audio.PlayOneShot(pickupsound);
		Destroy(coll.gameObject);	
		}
		if(coll.collider.name == "EndDoor"){
		fade.fadingOut = true;
		fade.fadeSpeed = 10;
		audio.PlayOneShot(opendoor);
			leveldone = true;
			Debug.Log("It Works");
		//Application.LoadLevel("Menu");	
		}
	}
}
