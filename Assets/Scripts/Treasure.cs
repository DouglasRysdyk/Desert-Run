using UnityEngine;
using System.Collections;

public class Treasure : MonoBehaviour {

	public int value = 10;
	public GameObject explosionPrefab;
	public GameObject player;
	private PlayerController playerCtrl;

	private void Start() {
		playerCtrl = player.GetComponent<PlayerController>();
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Player") {
			if (GameManager.gm!=null) {
				// tell the game manager to Collect
				GameManager.gm.Collect (value);
			}

			playerCtrl.health += 10;

			// explode if specified
			if (explosionPrefab != null) {
				Instantiate (explosionPrefab, transform.position, Quaternion.identity);
			}

			// destroy after collection
			Destroy (gameObject);
		}
	}
}
