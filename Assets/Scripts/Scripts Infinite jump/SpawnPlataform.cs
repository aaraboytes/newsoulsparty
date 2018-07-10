using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlataform : MonoBehaviour {
	public GameObject[] items;
	public GameObject pared1;
	public GameObject pared2;





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn ()
	{
		Instantiate(

			items[ Random.Range(0,items.Length)],
			new Vector3(Random.Range(-70,70),this.transform.position.y),
			new Quaternion(0,0,90,1)


		);
<<<<<<< HEAD
		/*Instantiate(
=======
		Instantiate(
>>>>>>> d2996fe81b03787641b263251df0f4049c60debf

			pared1,
			new Vector3(-75,this.transform.position.y),
			Quaternion.identity


		);
		Instantiate(

			pared2,
			new Vector3(86,this.transform.position.y),
			new Quaternion(0,0,90,1)


<<<<<<< HEAD
		);*/
=======
		);
>>>>>>> d2996fe81b03787641b263251df0f4049c60debf

		
		Debug.Log("spawn");

	}
}
