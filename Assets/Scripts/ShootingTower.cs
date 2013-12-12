using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingTower : MonoBehaviour {
	private GameObject target;
	private Vector3 PositionTarget;
	public Transform muzzle;
	private float tijd;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
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
<<<<<<< HEAD
				float newXPos = (newBullet.transform.position.x-target.transform.position.x)*-1;
				float newYPos = (newBullet.transform.position.y-target.transform.position.y)*-1;
				float newZPos = (newBullet.transform.position.z-target.transform.position.z)*-1;
				float bSp = 10;
				newBullet.rigidbody.AddRelativeForce(newXPos*bSp, newYPos*bSp, newZPos*bSp);
				tijd = 0.1f;
			}
=======
				newBullet.transform.Rotate(0, 0, 0);
				newBullet.transform.Translate(transform.position);
				//newBullet.AddRelativeForce(PositionTarget);
				tijd = 0.1f;
			}
		}

	}
	void OnTriggerStay(Collider col)
	{
		if(col.name == "Enemy"){
			PositionTarget = new Vector3(target.transform.position.x * 100,0,target.transform.position.z * 100);

>>>>>>> 841fbfe1e2b720d428ecc5776b3091c3c17cbbf2
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
			if(enemiesInRange.Contains(col.gameObject))
			{
			enemiesInRange.Remove(col.gameObject);
			}
		}

	}
}
