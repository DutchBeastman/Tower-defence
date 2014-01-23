using UnityEngine;
using System.Collections;

public class Upgrade : MonoBehaviour {
	//privates
	private GameObject currency;

	//private int totalCurrency;
	public float nativeWidth = 1920.0f;
	public float nativeHeight = 1080.0f;

	public Texture upgradeTexture1;
	public Texture upgradeTexture2;
	public Texture upgradeTexture3;
	private bool Upgrade1 = false;
	private Vector3 guiPosition;
	//private Rect windowRect = new Rect(20, 20, 300, 50);//300
	private bool doWindow0 = false;
	private bool doWindow1 = false;
	public int DI = 0;//direction Int
	private bool doWindow2 = false;
	public int RI = 0;//Rotating It
	private Rect windowRect0 ;
	private Rect windowRect1 ;
	private float posX = 0f;
	private float posZ = 0f;
	private Vector3 rotationTurret;
	private int offsetPos = 20;
	private float TurretRotation;
	private Vector3 PositionsOfTurrets;
	private string UpgradeWindow1 = "Build Turret -- 120 Candy";
	private string UpgradeWindow2 = "Build Big Turret -- 260 Candy";
	private string UpgradeWindow3 = "Build Tripple Turret -- 380 Candy";
	private int damageUpgradeVariable = 100;
	private int speedUpgradeVariable = 80;
	private bool clicked = false;
	private Color defaultColor;
	private Color mouseOverColor;
	private int damageUpgradeCost = 100;
	private int speedUpgradeCost = 80;
	public int turretSelect;


	//Start making Buttons
	void Start(){
		mouseOverColor = new Color(10,0,0,0.1f);
		defaultColor = renderer.material.color;
		rotationTurret = new Vector3(0,0,TurretRotation);
		PositionsOfTurrets = new Vector3(transform.position.x + posX,transform.position.y,transform.position.z + posZ);
	}
	void Update(){

		//currency = GetComponent<Candy>().candy;
		guiPosition = Camera.main.WorldToScreenPoint(transform.position);
		windowRect0 = new Rect(guiPosition.x - 100,  Screen.height - guiPosition.y - 100, 230, 115);
		windowRect1 = new Rect(guiPosition.x - 100,  Screen.height - guiPosition.y - 150, 200, 60);

			if (Input.GetButtonDown("Fire2")){
				doWindow0 = false;


			}

	}

	void OnMouseUp(){

	}
	void OnMouseDown(){
		doWindow0 = true;
		//doWindow1 = true;
		if(gameObject.name == "side1")
		{
			posZ = posZ - offsetPos;
			DI = 2;//Rotating It
			clicked = true;
		}
		if(gameObject.name == "side2")
		{
			posZ = posZ + offsetPos;
			DI = 0;//Rotating It
		}
		if(gameObject.name == "side3")
		{
			posX = posX - offsetPos;
			DI = 1;//Rotating It
			clicked = true;
		}
		if(gameObject.name == "side4")
		{
			posX = posX + offsetPos;
			DI = 3;//Rotating It
			clicked = true;
		}

	}
	void OnMouseExit(){
		renderer.material.color = defaultColor;
	}
	void OnMouseOver() {

		renderer.material.color = mouseOverColor;
	}
	void OnGUI() {
		//GUI.Window(0, new Rect(guiPosition.x - 100,  Screen.height - guiPosition.y - 150, 200, 60), DoWindow0, "Basic Window");//200
		if(doWindow0){
			GUI.Window(0, new Rect(guiPosition.x - 100,  Screen.height - -guiPosition.y - 150, 200, 460), DoWindow0, "Building Upgrade:");//200
			GUI.color = Color.gray;
			windowRect0 = GUI.Window(0, windowRect0, DoWindow0, "Building Upgrade: ");
			}
		}
	void DoWindow0(int windowID) {

		if(Upgrade1 == false){
			if (GUI.Button(new Rect(10, 20, 160, 23), UpgradeWindow1)){
				if(Candy.candy >= 120)
				{
					GUI.color = Color.green;
					GameObject newTurret = Instantiate(Resources.Load("Prefabs/Cannon"), PositionsOfTurrets, Quaternion.identity) as GameObject;
					newTurret.name = "Turret";
					int NDI = DI * 90;// New Rotating It // Rotating Int
					newTurret.transform.Rotate(0,NDI,0);
					//UpgradeWindow1 = "Damage Upgrade";
					Candy.candy -= 120;
					Upgrade1 = true;
					doWindow0 = false;
					turretSelect = 0;
				}
			
			}
		}
		if(!Upgrade1){
		if (GUI.Button(new Rect(10, 50, 190, 23), UpgradeWindow2)){

				if(Candy.candy >= 260)
				{
					GUI.color = Color.green;
					GameObject newTurret = Instantiate(Resources.Load("Prefabs/Big Cannon"), PositionsOfTurrets, Quaternion.identity) as GameObject;
					newTurret.name = "Turret";
					int NDI = DI * 90;// New Rotating It // Rotating Int
					newTurret.transform.Rotate(0,NDI,0);
					//UpgradeWindow2 = "Damage Upgrade";
					Candy.candy -= 260;
					Upgrade1 = true;
					doWindow0 = false;
					turretSelect = 1;
				}
			}
		}
		if(!Upgrade1){
		if (GUI.Button(new Rect(10, 80, 210, 23), UpgradeWindow3)){

				if(Candy.candy >= 380)
				{
					GUI.color = Color.green;
					GameObject newTurret = Instantiate(Resources.Load("Prefabs/Tripple Cannon"), PositionsOfTurrets, Quaternion.identity) as GameObject;
					newTurret.name = "Turret";
					int NDI = DI * 90;// New Rotating It // Rotating Int
					newTurret.transform.Rotate(0,NDI,0);
					//UpgradeWindow3 = "Damage Upgrade";
					Candy.candy -= 380;
					Upgrade1 = true;
					doWindow0 = false;
					turretSelect = 2;
				}
			}
		}
		if(Upgrade1){
			windowRect0 = new Rect(guiPosition.x - 100,  Screen.height - guiPosition.y - 100, 230,250);
			if (GUI.Button(new Rect(10, 20, 210, 23), "Damage Upgrade --" + damageUpgradeCost)){
				if(Candy.candy >= damageUpgradeVariable){
					Candy.candy -= damageUpgradeCost;
					ShootingTower.towerDamage += 1;
					damageUpgradeCost += 10;

				}
		}
			if (GUI.Button(new Rect(10, 60, 210, 23), "Speed --" + speedUpgradeCost)){
				if(Candy.candy >= speedUpgradeVariable){
					Candy.candy -= speedUpgradeCost;
					ShootingTower.shootingSpeed -= 0.05f;
					speedUpgradeCost += 10;
					
				}
			}
			if (GUI.Button(new Rect(10, 100, 210, 23), "Sell")){
				if(Candy.candy >= speedUpgradeVariable){
					Upgrade1 = false;
					ShootingTower.removeTurret = true;
					if(turretSelect == 0)
					{
						Candy.candy += 60;
					}
					if(turretSelect == 1)
					{
						Candy.candy += 130;
					}
					if(turretSelect == 2)
					{
						Candy.candy += 190;
					}
					
				}
			}

		}
	//doWindow0 = false;
	}	
}
