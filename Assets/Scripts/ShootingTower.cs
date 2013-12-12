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
		tijd = 0.1f;
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
				float newXPos = (newBullet.transform.position.x-target.transform.position.x)*-1;
				float newYPos = (newBullet.transform.position.y-target.transform.position.y)*-1;
				float newZPos = (newBullet.transform.position.z-target.transform.position.z)*-1;
				float bSp = 10;
				newBullet.rigidbody.AddRelativeForce(newXPos*bSp, newYPos*bSp, newZPos*bSp);
				tijd = 0.1f;
			}
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
		target = enemiesInRange[enemiesInRange.Clear()];
		if(col.name == "Enemy")
		{
			rotating = false;
		}

	}
}
