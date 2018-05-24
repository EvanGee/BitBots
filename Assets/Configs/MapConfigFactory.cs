using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapConfigFactory {

	public MapConfigFactory() {
	}

	public MapConfig tutorial(){
		MapConfig map = new MapConfig ();
		map.spawnLocations = new Vector3[2];
		map.spawnLocations [0] = new Vector3 (0, 1, 0);
		map.spawnLocations [1] = new Vector3 (2, 1, 2);
		return map;
	}
}
