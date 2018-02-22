using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (clickcontrol.objsleft <= 0)
        {
            Application.Quit();
        }
	}
}
