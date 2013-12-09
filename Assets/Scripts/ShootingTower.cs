using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingTower : MonoBehaviour {
	public GameObject target;
	public Transform muzzle;
	private float tijd;
	List<GameObject> enemiesInRange = new List<GameObject>(); 
	private bool rotating = false;
	void Start(){
		tijd = 1f;
	}
	void FixedUpdate(){
		if(rotating == true)
		{

			tijd -= Time.deltaTime;
			transform.LookAt(target.transform.position);
			if(tijd <= 0)
			{
				GameObject newBullet = Instantiate(Resources.Load("Prefabs/Rocket"), transform.position, Quaternion.identity) as GameObject;
				newBullet.name = "Bullet";
				newBullet.transform.Rotate(0, 0, 0);
				//maakt het weird spawnen achter de building
				//newBullet.transform.Translate(transform.position);
				newBullet.rigidbody.AddRelativeForce(0, 10 ,10);
				tijd = 1f;
			}
<<<<<<< HEAD
=======


>>>>>>> 5dad5e9d01d3a2ed6244af25f1c63e7992358dfe
		}
	}
	void OnTriggerEnter(Collider col)
	{	
		if(col.name == "Enemy"){
			rotating = true;
			enemiesInRange.Add(col.gameObject);
			target = enemiesInRange[0];
		}
	}
	void OnTriggerExit(Collider col)
	{
		if(col.name == "Enemy")
		{
			rotating = false;
		}
	}
}
