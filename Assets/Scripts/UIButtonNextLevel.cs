using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIButtonNextLevel : MonoBehaviour {

	public string NextLevelToLoad;

	public void loadNextLevel() {
		//Load the level from LevelToLoad
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
