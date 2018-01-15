using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public GameObject bear;

	float bearPos =0f;

	public Text score;
	int x=0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		bearPos = bear.transform.position.y;

		if (x < bearPos) {
			x++;
		}
//		int i = 0;
//		for(i=5000;x>i;x++)
//
		score.text = x.ToString ();
	}
}
