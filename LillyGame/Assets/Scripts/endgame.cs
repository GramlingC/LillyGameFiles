using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //End Game if all tagged objects are gone
        if (GameObject.FindGameObjectsWithTag("TargetObject").Length <= 0)
        {
            Application.Quit();
        }
	}
}
