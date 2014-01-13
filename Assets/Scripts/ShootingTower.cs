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
	private int EnemieCounter; 
	public bool rotating = false;
	public bool RotatingToZeroBool = false;
	private Upgrade SRI;
	private int NRI;
	private GameObject enemyguy = null;
	private int towerDamage = 1;





	void Start(){

		tijd = 0.1f;
		EnemieCounter = 0;
		SRI = GetComponent<Upgrade>();
		//NRI = SRI.GetComponent<Upgrade>().RI;
		//Debug.Log(SRI.RI);
		RotatingToZeroPos = new Vector3(0, NRI * 90, 0);
	}
	void FixedUpdate(){

		if(RotatingToZeroBool == true)
		{
		//	transform.rotation = new Quaternion(0,NRI*90,0, 0);
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

	void OnTriggerStay(Collider col)
	{

		rotating = false;
		if(col.name == "Enemy"){
			transform.LookAt(target.transform.position);
			PositionTarget = new Vector3(target.transform.position.z ,0,target.transform.position.x );
			target = enemiesInRange[0];
			rotating = true;
			shooting = true;
			enemyguy = target;
			enemyguy.GetComponent<EnemyHealth>().TakeDamage(towerDamage);

		}
		if(enemiesInRange.Contains(col.gameObject))
		{
			enemiesInRange.Remove(col.gameObject);
			EnemieCounter -=1;
			
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
			target = null;
			//transform.LookAt(RotatingToZero);
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
