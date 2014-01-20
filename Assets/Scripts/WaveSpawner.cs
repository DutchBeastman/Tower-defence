using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {
	
	private float timeBetweenSpawningEnemy;
	private float decreasedSpawnTime;
	private int numberOfEnemysPerWave;
	public float timeBetweenWaves;
	private int waves;
	private float evolvingNumber;
	private int NewWaveSpawnTimer;
	public float nativeWidth = 1024.0f;
	public float nativeHeight = 768.0f;
	public GUIStyle stylos;
	public bool onAndOff = false;
	public bool spawningIsTrue = true;

	void Start(){
		numberOfEnemysPerWave = 10;
		timeBetweenWaves = 35;
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
			if(waves == 30)
			{
				numberOfEnemysPerWave += 1;
			}else if(waves == 40)
			{
				numberOfEnemysPerWave += 1;
			}else if(waves == 55)
			{
				numberOfEnemysPerWave += 2;
			}else if(waves == 75)
			{
				numberOfEnemysPerWave += 3;
			}else if(waves == 100)
			{
				numberOfEnemysPerWave += 3;
			}
		}
	}
	///////starting a wave
	void startWaves(){
		waves ++;
		if(waves >= 5)
		{
			if(waves == 5)
			{
				evolvingNumber += 1;// balance for after 25 rounds getting heavyEnemy's
			}
			evolvingNumber += 0.2f;// 75 rounds to fully getting heavyEnemy's
		}
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
			yield return new WaitForSeconds(timeBetweenSpawningEnemy);
		}
//		yield return new WaitForSeconds(timeBetweenWaves);

	}
	void OnGUI() {
		if(onAndOff){
		float rx = Screen.width / nativeWidth;
		float ry = Screen.height / nativeHeight;
		GUI.matrix = Matrix4x4.TRS (new Vector3(0, 0, 0), Quaternion.identity, new Vector3 (rx, ry, 1));
		NewWaveSpawnTimer = (int)timeBetweenWaves;
		GUI.Label(new Rect(950, 10, 100, 20), "Time: " +  NewWaveSpawnTimer ,stylos);
		//candyCounter.text = "Candy: " + candy;
		}
		
		
	}
	void setTimeBetweenSpawn(){
		if(waves >= 20)
		{
			decreasedSpawnTime = (((waves * 2) + (waves/(waves/waves)))/100);
		}
		timeBetweenSpawningEnemy = 1.2f - decreasedSpawnTime;
	}

	void spawnEnemy(){
		if(spawningIsTrue){
			setTimeBetweenSpawn();
			float enemyChooseNumber = (Mathf.Ceil(Random.value * 5) + evolvingNumber);// random number between 0 and 5 + float that increases with every wave
			if(enemyChooseNumber <= 5)
			{
				float sadGohstPicker = Mathf.Ceil(Random.value * 5);
				if(sadGohstPicker == 1){
					GameObject newEnemy11 = Instantiate(Resources.Load("Prefabs/Enemies/NormalEnemy11"),transform.position , Quaternion.identity) as GameObject;
					newEnemy11.transform.Rotate(0,90,0);
					newEnemy11.name = "Enemy";
				}else if(sadGohstPicker == 2){
					GameObject newEnemy12 = Instantiate(Resources.Load("Prefabs/Enemies/NormalEnemy12"),transform.position , Quaternion.identity) as GameObject;
					newEnemy12.transform.Rotate(0,90,0);
					newEnemy12.name = "Enemy";
				}else if(sadGohstPicker == 3){
					GameObject newEnemy2 = Instantiate(Resources.Load("Prefabs/Enemies/NormalEnemy2"),transform.position , Quaternion.identity) as GameObject;
					newEnemy2.transform.Rotate(0,90,0);
					newEnemy2.name = "Enemy";
				}else if(sadGohstPicker == 4){
					GameObject newEnemy31 = Instantiate(Resources.Load("Prefabs/Enemies/NormalEnemy31"),transform.position , Quaternion.identity) as GameObject;
					newEnemy31.transform.Rotate(0,90,0);
					newEnemy31.name = "Enemy";
				}else if(sadGohstPicker == 5){
					GameObject newEnemy32 = Instantiate(Resources.Load("Prefabs/Enemies/NormalEnemy32"),transform.position , Quaternion.identity) as GameObject;
					newEnemy32.transform.Rotate(0,90,0);
					newEnemy32.name = "Enemy";
				}
			}else if(enemyChooseNumber > 5 && enemyChooseNumber < 10)
			{
				float naughtyGohstPicker = Mathf.Ceil(Random.value * 5);
				if(naughtyGohstPicker == 1){
					GameObject newEnemy11 = Instantiate(Resources.Load("Prefabs/Enemies/FastEnemy11"),transform.position , Quaternion.identity) as GameObject;
					newEnemy11.transform.Rotate(0,90,0);
					newEnemy11.name = "Enemy";
				}else if(naughtyGohstPicker == 2){
					GameObject newEnemy12 = Instantiate(Resources.Load("Prefabs/Enemies/FastEnemy12"),transform.position , Quaternion.identity) as GameObject;
					newEnemy12.transform.Rotate(0,90,0);
					newEnemy12.name = "Enemy";
				}else if(naughtyGohstPicker == 3){
					GameObject newEnemy2 = Instantiate(Resources.Load("Prefabs/Enemies/FastEnemy2"),transform.position , Quaternion.identity) as GameObject;
					newEnemy2.transform.Rotate(0,90,0);
					newEnemy2.name = "Enemy";
				}else if(naughtyGohstPicker == 4){
					GameObject newEnemy31 = Instantiate(Resources.Load("Prefabs/Enemies/FastEnemy31"),transform.position , Quaternion.identity) as GameObject;
					newEnemy31.transform.Rotate(0,90,0);
					newEnemy31.name = "Enemy";
				}else if(naughtyGohstPicker == 5){
					GameObject newEnemy32 = Instantiate(Resources.Load("Prefabs/Enemies/FastEnemy32"),transform.position , Quaternion.identity) as GameObject;
					newEnemy32.transform.Rotate(0,90,0);
					newEnemy32.name = "Enemy";
				}
			}else if(enemyChooseNumber > 10 && enemyChooseNumber <= 15)
			{
				float wolfPicker = Mathf.Ceil(Random.value * 5);
				if(wolfPicker == 1){
					GameObject newEnemy11 = Instantiate(Resources.Load("Prefabs/Enemies/HeavyEnemy11"),transform.position , Quaternion.identity) as GameObject;
					newEnemy11.transform.Rotate(0,90,0);
					newEnemy11.name = "Enemy";
				}else if(wolfPicker == 2){
					GameObject newEnemy12 = Instantiate(Resources.Load("Prefabs/Enemies/HeavyEnemy12"),transform.position , Quaternion.identity) as GameObject;
					newEnemy12.transform.Rotate(0,90,0);
					newEnemy12.name = "Enemy";
				}else if(wolfPicker == 3){
					GameObject newEnemy2 = Instantiate(Resources.Load("Prefabs/Enemies/HeavyEnemy2"),transform.position , Quaternion.identity) as GameObject;
					newEnemy2.transform.Rotate(0,90,0);
					newEnemy2.name = "Enemy";
				}else if(wolfPicker == 4){
					GameObject newEnemy31 = Instantiate(Resources.Load("Prefabs/Enemies/HeavyEnemy31"),transform.position , Quaternion.identity) as GameObject;
					newEnemy31.transform.Rotate(0,90,0);
					newEnemy31.name = "Enemy";
				}else if(wolfPicker == 5){
					GameObject newEnemy32 = Instantiate(Resources.Load("Prefabs/Enemies/HeavyEnemy32"),transform.position , Quaternion.identity) as GameObject;
					newEnemy32.transform.Rotate(0,90,0);
					newEnemy32.name = "Enemy";
				}

			}

		}

	}
}
