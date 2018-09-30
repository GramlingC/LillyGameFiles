using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockInfoPanel : MonoBehaviour {

    public GameObject Panel; // The panel we want to display and hide

	// Use this for initialization
	void Start () {
         Panel.SetActive(false); //Always have it off
         //PlayerPrefs.SetInt("hasSeenInfoPanel", 0); //debugging


        if (PlayerPrefs.GetInt("rewardAnimal_1") == 1) //If level one is complete
        {
            if (PlayerPrefs.GetInt("hasSeenInfoPanel") == 0) //Only need to view it once
            {
                Panel.SetActive(true); //Display panel
            }
        }

    }

    public void Close()
    {
        PlayerPrefs.SetInt("hasSeenInfoPanel", 1); //Record that is has been displayed
        Panel.SetActive(false); //Turn it off

    }

    // Update is called once per frame
    void Update () {
		
	}
}
