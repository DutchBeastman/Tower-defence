using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {
	
	private float timeBetweenSpawningEnemy;
	private float decreasedSpawnTime;
	private int numberOfEnemysPerWave;
	public float timeBetweenWaves;
	private int waves;
	private float evolvingNumber;

	void Start(){
		numberOfEnemysPerWave = 100;
		timeBetweenWaves = 5;
		waves = 0;
	}


	void Update(){
		if(Input.GetKeyDown(KeyCode.L))
		{
			startWaves();
		}
		timeBetweenWaves -= Time.deltaTime;
		if(timeBetweenWaves <= 0)
		{
			startWaves();

		}
	}
	///////starting a wave
	void startWaves(){
		waves ++;
		Debug.Log(waves);
		setTimeBetweenSpawn();
		StartCoroutine(spawnWave());
	}
	///////calling enemy spawn function
	IEnumerator spawnWave ()
	{
		timeBetweenWaves = 35;
		for(int i = 0; i < numberOfEnemysPerWave; i ++)
		{
			spawnEnemy();
			print("Spawned an enemy.");
			yield return new WaitForSeconds(timeBetweenSpawningEnemy);
		}
		yield return new WaitForSeconds(timeBetweenWaves);
		print("All enemys are spawned.");

	}
	void setTimeBetweenSpawn(){
		if(waves >= 20)
		{
			decreasedSpawnTime = (((waves * 2) + (waves/(waves/waves)))/100);
		}
		timeBetweenSpawningEnemy = 1.2f - decreasedSpawnTime;
	}

	void spawnEnemy(){
		setTimeBetweenSpawn();
		float enemyChooseInt = (Mathf.Ceil(Random.value * 5) + evolvingNumber);
		if(enemyChooseInt <= 5)
		{
			float sadGohstPicker = Mathf.Ceil(Random.value * 5);
			if(sadGohstPicker == 1){
				GameObject newEnemy11 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy11"),transform.position , Quaternion.identity) as GameObject;
				newEnemy11.transform.Rotate(0,90,0);
				newEnemy11.name = "Enemy";
			}else if(sadGohstPicker == 2){
				GameObject newEnemy12 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy12"),transform.position , Quaternion.identity) as GameObject;
				newEnemy12.transform.Rotate(0,90,0);
				newEnemy12.name = "Enemy";
			}else if(sadGohstPicker == 3){
				GameObject newEnemy2 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy2"),transform.position , Quaternion.identity) as GameObject;
				newEnemy2.transform.Rotate(0,90,0);
				newEnemy2.name = "Enemy";
			}else if(sadGohstPicker == 4){
				GameObject newEnemy31 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy31"),transform.position , Quaternion.identity) as GameObject;
				newEnemy31.transform.Rotate(0,90,0);
				newEnemy31.name = "Enemy";
			}else if(sadGohstPicker == 5){
				GameObject newEnemy32 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy32"),transform.position , Quaternion.identity) as GameObject;
				newEnemy32.transform.Rotate(0,90,0);
				newEnemy32.name = "Enemy";
			}
		}else if(enemyChooseInt > 5 && enemyChooseInt < 10)
		{
			float naughtyGohstPicker = Mathf.Ceil(Random.value * 5);
			if(naughtyGohstPicker == 1){
				//GameObject newEnemy11 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy11"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy11.transform.Rotate(0,90,0);
				//newEnemy11.name = "Enemy";
			}else if(naughtyGohstPicker == 2){
				//GameObject newEnemy12 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy12"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy12.transform.Rotate(0,90,0);
				//newEnemy12.name = "Enemy";
			}else if(naughtyGohstPicker == 3){
				//GameObject newEnemy2 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy2"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy2.transform.Rotate(0,90,0);
				//newEnemy2.name = "Enemy";
			}else if(naughtyGohstPicker == 4){
				//GameObject newEnemy31 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy31"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy31.transform.Rotate(0,90,0);
				//newEnemy31.name = "Enemy";
			}else if(naughtyGohstPicker == 5){
				//GameObject newEnemy32 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy32"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy32.transform.Rotate(0,90,0);
				//newEnemy32.name = "Enemy";
			}
		}else if(enemyChooseInt > 10 && enemyChooseInt <= 15)
		{
			float wolfPicker = Mathf.Ceil(Random.value * 5);
			if(wolfPicker == 1){
				//GameObject newEnemy11 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy11"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy11.transform.Rotate(0,90,0);
				//newEnemy11.name = "Enemy";
			}else if(wolfPicker == 2){
				//GameObject newEnemy12 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy12"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy12.transform.Rotate(0,90,0);
				//newEnemy12.name = "Enemy";
			}else if(wolfPicker == 3){
				//GameObject newEnemy2 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy2"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy2.transform.Rotate(0,90,0);
				//newEnemy2.name = "Enemy";
			}else if(wolfPicker == 4){
				//GameObject newEnemy31 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy31"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy31.transform.Rotate(0,90,0);
				//newEnemy31.name = "Enemy";
			}else if(wolfPicker == 5){
				//GameObject newEnemy32 = Instantiate(Resources.Load("Prefabs/Enemies/Enemy32"),transform.position , Quaternion.identity) as GameObject;
				//newEnemy32.transform.Rotate(0,90,0);
				//newEnemy32.name = "Enemy";
			}

		}


	}
}
