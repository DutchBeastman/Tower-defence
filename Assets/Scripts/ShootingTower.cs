using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingTower : MonoBehaviour {

	public bool shooting = false;
	private GameObject target;
	private Vector3 PositionTarget;
	private Vector3 RotatingToZeroPos; 
	private Vector3 bulletPos;
	public Transform muzzle;
	public float tijd;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	private int EnemyCounter; 
	public bool rotating = false;
	public bool RotatingToZeroBool = false;
	private Upgrade SRI;
	private int NRI;
	private GameObject enemyguy;
	private int towerDamage = 1;




	void Start(){

		tijd = 0.1f;
		EnemyCounter = 0;
		SRI = GetComponent<Upgrade>();
		//NRI = SRI.GetComponent<Upgrade>().RI;
		//Debug.Log(SRI.RI);
		RotatingToZeroPos = new Vector3(0, NRI * 90, 0);
	}
	void Update(){

		if(!target){
			if(enemiesInRange.Contains(target)){
				enemiesInRange.Remove(target);
			}
			if(enemiesInRange.Count >= 1){
				target = enemiesInRange[0];
			}
		if(RotatingToZeroBool == true)
		{
			transform.rotation = new Quaternion(0,NRI*90,0, 0);
		}
		if(rotating == true)
		{

			tijd -= Time.deltaTime;

			if(tijd <= 0)
			{

				//Oude Bullet Spawn en fire script
				/*GameObject newBullet = Instantiate(Resources.Load("Prefabs/BulletFire"),transform.position , Quaternion.identity) as GameObject;
				newBullet.name = "Bullet";

				float newXPos = (newBullet.transform.position.x-target.transform.position.x)*-1;
				float newYPos = (newBullet.transform.position.y-target.transform.position.y)*-1;
				float newZPos = (newBullet.transform.position.z-target.transform.position.z)*-1;
				float bSp = 150;
				newBullet.rigidbody.AddRelativeForce(newXPos*bSp, newYPos*bSp, newZPos*bSp);*/
				tijd = 0.5f;

				}
			}
		}

	}

	void OnTriggerStay(Collider col)
	{

		rotating = false;
		if(col.name == "Enemy"){



			rotating = true;
			shooting = true;

			if (target && (target.GetComponent<EnemyHealth>().healthCounter - towerDamage) <= 0)
			{

				enemiesInRange.Remove(target);

			}
			if(target)
			{
				transform.LookAt(target.transform.position);
				target.GetComponent<EnemyHealth>().TakeDamage(towerDamage);
			}
			else
			{
				target = null;
			}
		}
	}

	void OnTriggerEnter(Collider col)
	{	
		rotating = false;
		if(col.name == "Enemy"){
			RotatingToZeroBool = false;
			shooting = true;
			rotating = true;
			enemiesInRange.Add(col.gameObject);
			target =  enemiesInRange[0];
		}

	}

	void OnTriggerExit(Collider col)
	{

		if(col.name == "Enemy")
		{
			//transform.rotation = Quaternion.LookRotation(RotatingToZero);
			shooting = false;
			rotating = false;
			RotatingToZeroBool = true;
			//transform.LookAt(RotatingToZero);
			if(enemiesInRange.Contains(col.gameObject))
			{
				enemiesInRange.Remove(col.gameObject);

				if(target == col.gameObject){
					target = null;
				}
			
			}
		}

	}


}
