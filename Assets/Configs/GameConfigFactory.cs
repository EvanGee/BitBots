using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfigFactory {

	MapConfigFactory mapFactory = new MapConfigFactory ();
	BotConfigFactory botFactory = new BotConfigFactory ();
	public GameConfigFactory(){
	}

	public GameConfig tutorial() {
		GameConfig game = new GameConfig ();
		MapConfig map = mapFactory.tutorial ();
		game.map = map;
		game.bots = new BotConfig[2];
		for (int i = 0; i < game.bots.Length; i++) {
			game.bots[i] = botFactory.buildBasicBot ();
		}
		return game;
	}
}
