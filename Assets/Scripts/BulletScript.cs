using UnityEngine;
using System.Collections;


public class BulletScript : MonoBehaviour {
	private ShootingTower shootingtower;
	private GameObject enemyguy;

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


	}
	void OnCollisionEnter(Collision col){
		//Debug.Log(col.gameObject.name);
		if(col.gameObject.name == "Bullet")
		{

		}
		Destroy (gameObject);
		if(col.gameObject.name == "Enemy11" ||col.gameObject.name == "Enemy12" ||col.gameObject.name == "Enemy2" ||col.gameObject.name == "Enemy31" ||col.gameObject.name == "Enemy32")
		{
			
			enemyguy = GameObject.Find(col.gameObject.name);
			enemyguy.GetComponent<EnemyHealth>().TakeDamage(10);
			Destroy(gameObject, 3);
			//shootingtower.enemiesInRange.Remove(col.gameObject);
		}
	}
}
