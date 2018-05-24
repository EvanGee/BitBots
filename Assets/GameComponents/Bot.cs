using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour {
	//GameController
	private GameController gameController;

	private Stats coreStats;

	void Start () {
		GameObject sceneStateController = GameObject.FindWithTag("GameController");
		gameController = sceneStateController.GetComponent<GameController> ();
	}
		
	public void create(BotConfig conf) {
		coreStats = conf.stats;

		//GameObject movement = Instantiate(Movement, new Vector3(0, 0, 0), Quaternion.identity);
		//Bot bot = newBot.GetComponent<Bot> ();

	}
	// Update is called once per frame
	void Update () {
		foreach (Transform child in transform)
			child.GetComponent<IBotComponent>().act(gameController);
	}
}
