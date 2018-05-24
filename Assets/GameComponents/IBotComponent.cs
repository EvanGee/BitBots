using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IBotComponent {
	Stats getStats();
	void act(GameController state);
	void create (BotConfig conf);
}
