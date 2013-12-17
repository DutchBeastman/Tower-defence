using UnityEngine;
using System.Collections;


public class BulletScript : MonoBehaviour {
	private ShootingTower shootingtower;

	// Use this for initialization
	void Start () {

		ShootingTower shootingtower = (ShootingTower)this.GetComponent(typeof(ShootingTower));
	
	}
	// Update is called once per frame
	void Update () {
		float newXPos = (transform.position.x-transform.position.x );
		float newYPos = (transform.position.y-transform.position.y );
		float newZPos = (transform.position.z-transform.position.z );
		float bSp = 10;
		rigidbody.AddRelativeForce(newXPos*bSp, newYPos*bSp, newZPos*bSp);
	}
	void OnTriggerEnter(Collider col) {
		Destroy(gameObject);
		if(col.gameObject.name == "Enemy")
		{
			gameObject.GetComponent<EnemyHealth>().TakeDamage(10);

			//shootingtower.enemiesInRange.Remove(col.gameObject);
		}

	}
}
