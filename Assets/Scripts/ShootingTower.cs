﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingTower : MonoBehaviour {

	private GameObject target;
	private Vector3 PositionTarget;
	private Vector3 RotatingToZero;
	private Vector3 bulletPos;
	public Transform muzzle;
	public float tijd;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	private int EnemieCounter; 
	private bool rotating = false;



	void Start(){
		tijd = 0.1f;
		EnemieCounter = 0;
		RotatingToZero = new Vector3(0, 0, 0);



	}
	void FixedUpdate(){

		if(rotating == true)
		{

			tijd -= Time.deltaTime;
			transform.LookAt(target.transform.position);
			if(tijd <= 0)
			{
				Debug.Log("trace");

				GameObject newBullet = Instantiate(Resources.Load("Prefabs/Rocket"),transform.position , Quaternion.identity) as GameObject;
				newBullet.name = "Bullet";

				float newXPos = (newBullet.transform.position.x-target.transform.position.x)*-1;
				float newYPos = (newBullet.transform.position.y-target.transform.position.y)*-1;
				float newZPos = (newBullet.transform.position.z-target.transform.position.z)*-1;
				float bSp = 150;
				newBullet.rigidbody.AddRelativeForce(newXPos*bSp, newYPos*bSp, newZPos*bSp);
				tijd = 0.5f;


			}
		}
	}

	void OnTriggerStay(Collider col)
	{
		rotating = false;
		if(col.name == "Enemy"){
			PositionTarget = new Vector3(target.transform.position.z * 100,0,target.transform.position.x * 100);
			target = enemiesInRange[0];
			rotating = true;

		}
	}
	void OnTriggerEnter(Collider col)
	{	
		if(col.name == "Enemy"){

			rotating = true;
			enemiesInRange.Add(col.gameObject);
			target = col.gameObject;
		}
	}

	void OnTriggerExit(Collider col)
	{


		EnemieCounter += 1;
		rotating = false;

		if(col.name == "Enemy")
		{
			rotating = false;
			transform.LookAt(RotatingToZero);
			if(enemiesInRange.Contains(col.gameObject))
			{
				enemiesInRange.Remove(col.gameObject);
			}
		}

	}

























	void Update(){
		if(Input.GetKeyDown(KeyCode.N))
		{
			Application.LoadLevel("Dead");
		}


	}
}
