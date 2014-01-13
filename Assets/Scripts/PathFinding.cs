﻿
using UnityEngine;
using System.Collections;

public class PathFinding : MonoBehaviour {
	//public
	public float speed = 1;
	public float rotationSpeed = 1;
	public Transform [] waypoints;
	//private
	private int wayPointIndex;
	private Vector3 targetDist;
	public Vector3 enemyPos;


	//private

	//private bool direction;
	void Start(){
		wayPointIndex = 0;
		enemyPos = new Vector3(transform.rotation.x,transform.rotation.y,transform.rotation.z);

	}
	// switch direction
	void FixedUpdate () {
		if(waypoints.Length > 0){
			if(Vector3.Distance(transform.position, waypoints[wayPointIndex].position) < 1 )
			   {
				wayPointIndex++;
			}
				if(wayPointIndex == waypoints.Length) {
					wayPointIndex = 0;
				}
			
			if(waypoints[wayPointIndex])
			{
				Vector3 targetDist = waypoints[wayPointIndex].position - transform.position;
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetDist), rotationSpeed * Time.deltaTime);
				transform.Translate(Vector3.forward * speed * Time.deltaTime);
			}
		}
		
	}
	void OnTriggerEnter(Collider col)
	{	
		if(col.name == "waypoint"){
			//rotationSpeed += 0.5f;
			//speed -= 1;
			if(wayPointIndex == waypoints.Length) {
				wayPointIndex = 0;
				
			}

		}
	}
	void OnTriggerExit(Collider col)
	{
		if(col.name == "waypoint"){
			//rotationSpeed -= 0.5f;
			//speed += 1;
		}
	}

}
