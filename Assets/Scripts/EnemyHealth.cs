using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int healthCounter;
	public int damage;
	public Animator animator;
	public bool walk = true;
	public GameObject lifeCounter;
	public int hitBase = 1;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		if (animator) {
			animator.SetBool("Walk", walk);
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(healthCounter <= 0){

			Candy.candy += 5;
			Destroy(gameObject);
			GameObject CandyParticle = Instantiate(Resources.Load("Prefabs/EnemyDeath"),transform.position,Quaternion.identity) as GameObject;
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
	public void upLifes(int balance)
	{
		healthCounter += 1;
	}
}
