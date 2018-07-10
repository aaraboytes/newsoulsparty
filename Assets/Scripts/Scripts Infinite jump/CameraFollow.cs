using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.y > 0)
		{
			if(player.transform.position.y >transform.position.y)
			{
				this.transform.position=new Vector3(5, player.transform.position.y , -10); // si el jugador queda fuera de la escena reposiciona la camara  
				 
			}
		}
	}


}
