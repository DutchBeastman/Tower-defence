using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingTower : MonoBehaviour {

	public bool shooting = false;
	private GameObject target;
	private Vector3 positionTarget;
	private Vector3 rotatingToZeroPos; 
	private Vector3 bulletPos;
	public Transform muzzle;
	public float tijd;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	private int enemieCounter; 
	public bool rotating = false;
	public bool rotatingToZeroBool = false;
	//private Upgrade DI;//new direction int
	//private int NDI;//new direction int
	private GameObject enemyguy;
	private int towerDamage = 1;

	public bool tar;
	private Quaternion startRotation;


	void Start(){

		tijd = 0.1f;
		enemieCounter = 0;
		//SRI = GetComponent<Upgrade>();
		//NRI = SRI.GetComponent<Upgrade>().RI;
		//Debug.Log(SRI.RI);
		//rotatingToZeroPos = new Vector3(0, NRI * 90, 0);

		startRotation = transform.rotation;
	}
	void Update(){
		if (tar) 
			{
			if(rotatingToZeroBool)
			{
				//transform.rotation = new Quaternion(0,NRI*90,0, 0);
			}
			if(rotating == true)
			{

				tijd -= Time.deltaTime;
				transform.LookAt(target.transform.position);
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
		else 
		{
			transform.rotation = startRotation;
		}
	}

	void OnTriggerStay(Collider col)
	{

		rotating = false;
		if(col.name == "Enemy"){
			//positionTarget = new Vector3(target.transform.position.z ,0,target.transform.position.x );
			target = enemiesInRange[enemieCounter];
			rotating = true;
			shooting = true;
			enemyguy = target;
			enemyguy.GetComponent<EnemyHealth>().TakeDamage(towerDamage);

		}
		if(enemiesInRange.Contains(col.gameObject))
		{
			enemiesInRange.Remove(col.gameObject);
			enemieCounter -=1;
			
		}
	}

	void OnTriggerEnter(Collider col)
	{	
		rotating = false;
		if(col.name == "Enemy"){
			rotatingToZeroBool = false;
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
			rotatingToZeroBool = true;
			//transform.LookAt(RotatingToZero);
			if(enemiesInRange.Contains(col.gameObject))
			{
				enemiesInRange.Remove(col.gameObject);
			
			}
		}

	}

	void FixedUpdate(){
		if(Input.GetKeyDown(KeyCode.N))
		{
			Application.LoadLevel("Dead");
		}


	}
}
