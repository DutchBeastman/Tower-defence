using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int healthCounter;
	public int damage;
	public GameObject lifeCounter;
	private int hitBase = 1;
	// Use this for initialization
	void Start () {
		healthCounter = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if(healthCounter <= 0){

			Destroy(gameObject);
		}

	}
	void OnTriggerEnter(Collider col){
		if(col.name == "MainBase")
		{
			Destroy(gameObject);
			lifeCounter.GetComponent<Lifes>().LifeTaken(hitBase);
		}
	}
	public void TakeDamage(int damage)
	{
		healthCounter -= damage;
	}
}
