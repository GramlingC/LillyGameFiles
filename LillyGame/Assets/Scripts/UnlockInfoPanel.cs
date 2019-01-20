using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockInfoPanel : MonoBehaviour {

    public GameObject Panel; // The panel we want to display and hide
    public GameObject Panel2; // The panel we want to display and hide
    public GameObject Panel3; // The panel we want to display and hide

    // Use this for initialization
    void Start () {
         Panel.SetActive(false); //Always have it off
        Panel2.SetActive(false);
        Panel3.SetActive(false);

        if (PlayerPrefs.GetInt("rewardAnimal_5") == 1) //If Level 5 is complete
        {
            Debug.Log("rrewardAnimal5===11111");
            if (PlayerPrefs.GetInt("hasSeenInfoPanel3") == 0) //Only need to see it once
            {
                Debug.Log("hhhhaas not   seeen panel 33");
                Panel3.SetActive(true); // Display Panel
                PlayerPrefs.SetInt("hasSeenInfoPanel3", 1); //Record that it has been seen
            }
            Debug.Log("Has seeen paanel3");
        }

        if (PlayerPrefs.GetInt("rewardAnimal_3") == 1) //If llevel 3 is complete
        {
            Debug.Log("rererewardAnimall_3 = 1");
            if (PlayerPrefs.GetInt("hasSeenInfoPanel2") == 0)  //Only neeed to see it once
            {
                Panel2.SetActive(true); //Display Panel
                PlayerPrefs.SetInt("hasSeenInfoPanel2", 1); //Record that is has been seen
            }

        }
        
        if (PlayerPrefs.GetInt("rewardAnimal_1") == 1) //If level one is complete
        {
            if (PlayerPrefs.GetInt("hasSeenInfoPanel") == 0) //Only need to view it once
            {
                Panel.SetActive(true); //Display panel
                PlayerPrefs.SetInt("hasSeenInfoPanel", 1); //Record that is has been displayed

            }
        }



    }

    public void Close()
    {
        Panel.SetActive(false); //Turn it off
        Panel2.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
