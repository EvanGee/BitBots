using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour, IBotComponent {

	Stats stats;

	public Sensor() {

	}

	public Stats getStats(){
		return stats;
	}

	public void create(BotConfig botConf) {

	}

	public void act(GameController stateController){
		this.DetectBots (stateController);
	}

	public void DetectBots(GameController stateController) {

		Bot thisBot = this.GetComponentInParent<Bot> ();
		Bot[] bots = stateController.getBots ();
		for (int i = 0; i < bots.Length; i++){
			float distance = Vector3.Distance (bots[i].transform.position, thisBot.transform.position);
		}
/*
		RaycastHit[] hits;
		hits = Physics.RaycastAll(transform.position, transform.forward, 100.0F);

		for (int i = 0; i < hits.Length; i++)
		{
			RaycastHit hit = hits[i];
			Renderer rend = hit.transform.GetComponent<Renderer>();

			if (rend)
			{
				// Change the material of all hit colliders
				// to use a transparent shader.
				rend.material.shader = Shader.Find("Transparent/Diffuse");
				Color tempColor= Color.black;
				rend.material.color = tempColor;
			}
		}
*/
	}

}
