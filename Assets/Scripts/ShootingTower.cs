using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingTower : MonoBehaviour {

	public bool shooting = false;
	private GameObject target;
	private Vector3 positionTarget;
	private Vector3 bulletPos;
	public float tijd;
	public List<GameObject> enemiesInRange = new List<GameObject>(); 
	private int enemyCounter; 
	public bool rotating = false;
	private int towerDamage = 1;
	//for cannon rotation after aiming
	public bool tar;
	private Quaternion startRotation;


	void Start(){
		tijd = 0.1f;
		enemyCounter = 0;
		startRotation = transform.rotation;
	}
	void Update(){
		if(!target){
			if(enemiesInRange.Contains(target)){
				enemiesInRange.Remove(target);
			}
			if(enemiesInRange.Count >= 1){
				target = enemiesInRange[0];
			}
		}
		if (target) 
		{
			if(rotating == true)
			{
				tijd -= Time.deltaTime;
				transform.LookAt(target.transform.position);
				if(tijd <= 0)
				{
					tijd = 0.5f;
				}
			}
		} 
		else 
		{
			transform.rotation = startRotation;
		}
	

	}
	
	IEnumerator shoot()
	{
		yield return new WaitForSeconds(0.5f);
		if(target){
			target.GetComponent<EnemyHealth>().TakeDamage(towerDamage);
		}
	}
	void OnTriggerStay(Collider col)
	{

		rotating = false;
		if(col.name == "Enemy"){
			//positionTarget = new Vector3(target.transform.position.z ,0,target.transform.position.x );
			//target = enemiesInRange[enemyCounter];
			rotating = true;
			shooting = true;

		}
		if (target && (target.GetComponent<EnemyHealth>().healthCounter - towerDamage) <= 0)
		{

			enemiesInRange.Remove(target);

		}
		if(target)
		{
			transform.LookAt(target.transform.position);

		}
		else
		{
			target = null;
		}
	}

	void OnTriggerEnter(Collider col)
	{	

		rotating = false;
		if(col.name == "Enemy"){
			shooting = true;
			rotating = true;
			enemiesInRange.Add(col.gameObject);
			target =  enemiesInRange[0];
			StartCoroutine(shoot());
		}

	}

	void OnTriggerExit(Collider col)
	{

		if(col.name == "Enemy")
		{
			//transform.rotation = Quaternion.LookRotation(RotatingToZero);
			shooting = false;
			rotating = false;
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
