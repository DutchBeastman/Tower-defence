﻿using UnityEngine;
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
	public static int towerDamage;
	public static float shootingSpeed = 2.5f;
	public int shootingDamage;
	private bool isShooting = false;
	//for cannon rotation after aiming
	public bool tar;
	private Quaternion startRotation;
	private Animator animator1;
	public static bool removeTurret = false;



	void Start(){
		towerDamage = 0 + shootingDamage;
		tijd = 0.1f;
		enemyCounter = 0;
		startRotation = transform.rotation;
		animator1 = GetComponent<Animator>();

	}

	void Update(){
		if(removeTurret){
			Destroy(gameObject);
			removeTurret = false;
		}
		if(!target){
			animator1.SetBool("Shoot", false);
			if(enemiesInRange.Contains(target)){
				enemiesInRange.Remove(target);
			}
			if(enemiesInRange.Count >= 1){
				target = enemiesInRange[0];
			}
		}
		if (target) 
		{
			animator1.SetBool("Shoot", true);
			if(!isShooting){
				StartCoroutine(shoot());
				Debug.Log("yolo");
				isShooting = true;
			}
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
			animator1.SetBool("Shoot", false);
			transform.rotation = startRotation;
		}
	

	}
	
	IEnumerator shoot()
	{
		//yield return new WaitForSeconds(0.2f);
		animator1.SetBool("Shoot", false);

		yield return new WaitForSeconds(shootingSpeed);
		Debug.Log("schiet nu");
		if(target){
			animator1.SetBool("Shoot", true);
			target.GetComponent<EnemyHealth>().TakeDamage(towerDamage);
			//Debug.Log("I'm Shooting a" + towerDamage);

		}

		isShooting = false;	
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
			if(target)
			{
				///StartCoroutine(shoot());
			}
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
