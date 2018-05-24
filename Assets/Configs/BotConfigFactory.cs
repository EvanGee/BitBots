using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotConfigFactory{

	public BotConfigFactory() {

	}

	public BotConfig buildBasicBot() {
		BotConfig newBotStats = new BotConfig ();
		//BaseLine health
		newBotStats.stats = new Stats();
		newBotStats.stats.health = 10;
		return newBotStats;
	}
}
