using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour {

	private Bot[] bots;
	public GameObject BotPrefab;

	void Start() {
		Debug.Log ("Starting game");
		GameConfigFactory games = new GameConfigFactory ();
		GameConfig gameConf = games.tutorial ();

		Debug.Log(JsonUtility.ToJson (gameConf));


		bots = new Bot[gameConf.bots.Length];
		SpawnBots (gameConf);
	}

	//hardcoded untill can make gameConfigClass
	public void SpawnBots(GameConfig gameConfig){
		for (int i = 0; i < gameConfig.bots.Length; i++) {
			GameObject bot = SpawnBot (gameConfig.bots[i]);
			this.addBotToGame (bot, i);
			bot.transform.position = gameConfig.map.spawnLocations [i];
		}
	}

	public GameObject SpawnBot(BotConfig conf) {
		GameObject newBot = Instantiate(BotPrefab, new Vector3(0, 0, 0), Quaternion.identity);
		Bot bot = newBot.GetComponent<Bot> ();
		bot.create (conf);
		return newBot;
	}
		
	private void addBotToGame(GameObject bot, int i) {
		Bot botCode = bot.GetComponent<Bot> ();
		bots [i] = botCode;
	}
	public Bot[] getBots(){
		return bots;
	}
}
