using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadManager : MonoBehaviour {
	public static DeadManager _instance;
	public float gameTime;
	float timer;
	public Text timerText;
	public string winnerScene;
	[SerializeField]
	int[] bomb;

	void Awake(){
		_instance = this;
	}
	void Start(){
		bomb = new int[5];
	}
	void Update(){
		timer += Time.deltaTime;
		timerText.text = ((int)(gameTime - timer)).ToString ();
		if (timer > gameTime) {
			float max = 0;
			for (int i = 0; i < bomb.Length; i++) {
				if (bomb[i] > max) {
					max = bomb [i];
				}
			}
			for (int i = 0; i < bomb.Length; i++) {
				if (bomb [i] == max) {
					switch (i) {
					case 0:
						GameManager._instance.SetLastWinner ("P1.");
						break;
					case 1:
						GameManager._instance.SetLastWinner ("P2.");
						break;
					case 2:
						GameManager._instance.SetLastWinner ("P3.");
						break;
					case 3:
						GameManager._instance.SetLastWinner ("P4.");
						break;
					default:
						GameManager._instance.SetLastWinner ("");
						break;
					}
				}
			}
			SceneManager.LoadScene (winnerScene);
		}
	}
	public void incrementCounter(string player){
		switch (player) {
		case "P1.":
			 Destroy(gameObject,.5f);
            //bomb[0]++;
			break;
		case "P2.":
        Destroy(gameObject,.5f);
			bomb[1]++;
			break;
		case "P3.":
        Destroy(gameObject,.5f);
			bomb[2]++;
			break;
		case "P4.":
        Destroy(gameObject,.5f);
			bomb[3]++;
			break;
		default:
        Destroy(gameObject,.5f);
			bomb[4]++;
			break;
		}
	}
	public float getRemainingTime(){
		return gameTime - timer;
	}
}
