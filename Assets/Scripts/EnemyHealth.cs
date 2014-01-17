using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {
	public int healthCounter;
	public int damage;
	public Animator animator;
	public bool walk = true;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		healthCounter = 10;
		if (animator) {
			animator.SetBool("Walk", walk);

			
		}

	}
	
	// Update is called once per frame
	void Update () {
		if(healthCounter <= 0){

			Candy.candy += 5;
			Destroy(gameObject);
		}

	}
	public void TakeDamage(int damage)
	{
		healthCounter -= damage;
	}
}
