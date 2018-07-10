using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastAlivePlayer : MonoBehaviour {
	public List<Player> players = new List<Player>();
	public string winnerScene;
	// Use this for initialization
	void Start () {
		Player[] findPlayers = FindObjectsOfType<Player> ();
		players.Clear ();
		for (int i = 0; i < findPlayers.Length; i++) {
			players.Add (findPlayers [i]);
		}
		foreach(Player p in players){
			if (!p.isActiveAndEnabled) {
				players.Remove (p);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (players.Count > 1) {
			foreach (Player p in players) {
				if (!p.alive) {
					players.Remove (p);
				}
			}
		} else {
			string prefix = "";
			foreach (Player p in players) {
				prefix = p.prefixInput;
			}
			GameManager._instance.IncreaseScore (10,prefix);
			GameManager._instance.SetLastWinner (prefix);
			Debug.Log ("Winner" + prefix);
<<<<<<< HEAD
			Invoke ("GoToWinnerScene", 3.0f);
			CameraEffects._instance.FocusOnWinner (playerTransform);
=======
			SceneManager.LoadScene (winnerScene);
>>>>>>> d2996fe81b03787641b263251df0f4049c60debf
		}
	}
	void GoToWinnerScene(){
		SceneManager.LoadScene (winnerScene);
	}
}
