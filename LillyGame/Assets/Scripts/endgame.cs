﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour {
    public GameObject nextlevel_panel;
	// Use this for initialization
	void Start () {
        nextlevel_panel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //End Game if all tagged objects are gone
        if (GameObject.FindGameObjectsWithTag("TargetObject").Length <= 0)
        {
            //SceneManager.LoadScene("StartLevel");
            nextlevel_panel.SetActive(true);


        }
    }
}
