using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySecondScript : MonoBehaviour {

	public GameObject bulletPrefab;
	// Use this for initialization
	void Start () {
		for( int i=0;i<10;i++ )
		{
			GameObject bulletInstance = Instantiate (bulletPrefab);
			bulletInstance.transform.position += Vector3.right * i;
		}
	}
	
	// Update is called once per frame
	void Update () {
		MyScript primaryScript = GetComponent<MyScript> ();
		transform.Rotate (Vector3.up * primaryScript.speed);
	}
}
