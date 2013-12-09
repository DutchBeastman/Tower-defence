using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Shooting : MonoBehaviour {
	public Transform muzzle;
	public float Timer = 1f;
	private GameObject target;
	public float speed;
	private bool rotating = false;
	List<GameObject> enemiesInRange = new List<GameObject>(); 
	void Start () {
		//enemiesInRange.Add(col.gameObject);
		//target = enemiesInRange[0];
	}
	
	// Update is called once per frame
	void Update () {
		Timer -= 1f * Time.deltaTime;

		if(rotating){
			//Timer -= 1f * Time.deltaTime;
			muzzle.transform.LookAt(target.transform.position * speed);
		}
		if(rotating && Timer <= 0)
		{
			GameObject newrocket = Instantiate(Resources.Load("Prefabs/Rocket"), transform.position, Quaternion.identity) as GameObject;
			Timer = 0.4f;
		}

	}
	void OnTriggerEnter(Collider col)
	{
		if(col.name == "Enemy")
		{
			rotating = true;
			enemiesInRange.Add(col.gameObject);
			target = enemiesInRange[0];
		}
	}
	void OnTriggerExit(Collider col)
	{
		rotating = false;
		if(enemiesInRange.Contains(col.gameObject)) 
		{
			enemiesInRange.Remove(col.gameObject);
		}
	}
}