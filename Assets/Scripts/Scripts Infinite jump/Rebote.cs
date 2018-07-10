using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rebote : MonoBehaviour {
	 public float factorRebote = 17.5f;
	 public GameObject spawner;
	 bool hasSpawned = false;


	// Use this for initialization
	void Start () {
		spawner = GameObject.FindGameObjectWithTag("Respawn");


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if(other.GetComponent<Rigidbody2D>().velocity.y < 0 )
		{
		other.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		other.GetComponent<Rigidbody2D>().AddForce(Vector2.up * factorRebote, ForceMode2D.Impulse);
		Debug.Log("salto");
		}
		if(!hasSpawned)
		{
			spawner.SendMessage("Spawn");
			hasSpawned =true;

		}
	}
}
