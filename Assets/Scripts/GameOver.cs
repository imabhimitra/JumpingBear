using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public GameObject bear;
	public GameObject lifeLine;

	float bearPos =0f;
	float lifeLinePos=0f;

	public Text overText;
	string over="Ohh Droped!!!";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		bearPos = bear.transform.position.y;
		lifeLinePos = lifeLine.transform.position.x;

		if (bearPos < lifeLinePos) {

			overText.text = over.ToString ();

		}
		
	}
}
