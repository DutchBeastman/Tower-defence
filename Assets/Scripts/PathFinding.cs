
using UnityEngine;
using System.Collections;

public class PathFinding : MonoBehaviour {
	//public
	public Transform [] waypoints;
	private int wayPointIndex;
	public float Speed = 1;
	public float rotationSpeed = 1;
	private Vector3 targetDist;


	//private

	//private bool direction;
	void Start(){
		wayPointIndex = 0;

	}
	// switch direction
	void FixedUpdate () {
		if(waypoints.Length > 0){
			if(Vector3.Distance(transform.position, waypoints[wayPointIndex].position) < 1)
			   {
				wayPointIndex++;
			}
			if(wayPointIndex == waypoints.Length) {
				wayPointIndex = 0;

			}
			targetDist = transform.LookAt(waypoints[wayPointIndex].position) - transform.position;
			transform.rotation = Quaternion.Slerp(transform.Rotate, Quaternion.LookRotation(targetDist), rotationSpeed * Time.deltaTime);
			transform.Translate(Vector3.forward * Speed * Time.deltaTime);
		}
		
	}

}
