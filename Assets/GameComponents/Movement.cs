using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour, IBotComponent {

	Stats stats;
	// Use this for initialization
	void Start () {
	}

	public Stats getStats(){
		return stats;
	}

	public void create(BotConfig botConf) {

	}

	public void act(GameController stateController){
		Transform parent = this.transform.parent;
		float x = 1;
		float z = 1;

		parent.transform.Translate (x, 0, z);

	}

}
