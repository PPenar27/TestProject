using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {
	
	void Update () {
		if (Input.touchCount > 0) 
		{
			Touch touch = Input.GetTouch (0);
			if (touch.phase == TouchPhase.Began) 
			{
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				if (Physics.Raycast (ray)) 
				{
					FindObjectOfType<GameManager> ().AddScore ();
					Destroy (gameObject);
				}
			}
		}
		if (transform.position.y < -10) 
		{
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

}
