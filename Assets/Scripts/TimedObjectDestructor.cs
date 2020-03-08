using UnityEngine;
using System.Collections;

public class TimedObjectDestructor : MonoBehaviour {

	public float timeOut = 1.0f;
	public bool detachChildren = false;

	// Use this for initialization
	void Awake () {
		// invote the DestroyNow funtion to run after timeOut seconds
		Invoke ("DestroyNow", timeOut);
	}

	// Update is called once per frame
	void Update () {

	}

	void DestroyNow ()
	{
		if (detachChildren) { // detach the children before destroying if specified
			transform.DetachChildren ();
		}
		DestroyObject (gameObject);
		//Object.destroy(gameObject); //NEW - not working - "Assets\Scripts\TimedObjectDestructor.cs(26,10): error CS1501: No overload for method 'Destroy' takes 0 arguments"
	}
}
