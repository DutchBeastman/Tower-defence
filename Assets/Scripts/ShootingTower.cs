using UnityEngine;
using System.Collections;

public class ShootingTower : MonoBehaviour {
	public GameObject target;
	public GameObject Bullet;
	private float tijd;
	private bool rotating = false;
	void Start(){
		tijd = 1;
	}
	void Update(){
		if(rotating == true)
		{
			tijd -= Time.deltaTime;
			transform.LookAt(target.transform.position);
			if(tijd <= 0)
			{
				GameObject newBullet = Instantiate(Resources.Load("Prefabs/Bullet"), transform.position, Quaternion.identity) as GameObject;

				tijd = 1;
			}
			//newBullet.transform.Translate (-1, 0, 0);
		}
	}
	void OnTriggerEnter(Collider col)
	{	
		if(col.name == "Enemy"){
			rotating = true;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if(col.name == "Enemy")
		{
			rotating = false;
		}
	}
}
