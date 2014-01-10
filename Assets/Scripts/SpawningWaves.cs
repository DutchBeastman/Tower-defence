using UnityEngine;
using System.Collections;

public class SpawningWaves : MonoBehaviour {
	private float timer;
	//private bool s;pawn;
	private int waves;
	private float SPET;// SPawnEnemyTimer
	private float TSPET;// Time-of-SPawnEnemyTimer
	private float EPF;
	//private int EPI;


	// Use this for initialization
	void Start () {
		//spawn = false;
		timer = 1.5f;
		SPET = TSPET;
		TSPET = 1;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		SPET -= Time.deltaTime;
		
		if(timer <= 0)
		{
			//spawn = true;
			waves += 1;
			timer += 15;
		}

		switch(waves){
			case 1:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 2:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 3:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 4:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 5:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 6:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 7:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 8:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 9:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
			case 10:
				SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();SPE();
			break;
		}
	}
	//SPE = SPawnEnemy
	void SPE(){
		EPF = Mathf.Ceil(Random.value * 5);
		if(SPET <= 0)
		{
			Debug.Log("spet is aflgelopen");
			if(EPF == 1){
				Debug.Log("spawn1enemy");
				GameObject newEnemy11 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy11"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy11.transform.rotation = new Quaternion(0,90,0);
				newEnemy11.name = "Enemy";
				SPET = TSPET;
			}else if(EPF == 2){
				Debug.Log("spawn2enemy");
				GameObject newEnemy12 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy12"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy12.transform.rotation = new Quaternion(0,90,0);
				newEnemy12.name = "Enemy";
				SPET = TSPET;
			}else if(EPF == 3){
				Debug.Log("spawn3enemy");
				GameObject newEnemy2 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy2"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy2.transform.rotation = new Quaternion(0,90,0);
				newEnemy2.name = "Enemy";
				SPET = TSPET;
			}else if(EPF == 4){
				Debug.Log("spawn4enemy");
				GameObject newEnemy31 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy31"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy31transform.rotation = new Quaternion(0,90,0);
				newEnemy31.name = "Enemy";
				SPET = TSPET;
			}else if(EPF == 5){
				Debug.Log("spawn5enemy");
				GameObject newEnemy32 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy32"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy32.transform.rotation = new Quaternion(0,90,0);
				newEnemy32.name = "Enemy";
				SPET = TSPET;
			}
		}
	}
	//SPE2 = SPawnEnemy2
	void SPE2(){
		if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}
	}
	//SPE3 = SPawnEnemy3
	void SPE3(){
		if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}else if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}
	}
	/*
	//SPE4 = SPawnEnemy4
	void SPE4(){
		if(SPET <= 0){
			//GameObject  = Instantiate(Resources.Load(""),transform.position , Quaternion.identity) as GameObject;
			SPET = TSPET;
		}
	}*/
}

