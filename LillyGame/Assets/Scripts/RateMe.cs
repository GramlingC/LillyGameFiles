using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateMe : MonoBehaviour {

    public GameObject rateObject;

	// Use this for initialization
	void Start () {
        rateObject.SetActive(false);
        //PlayerPrefs.SetInt("haveRated", 0);//debugging

        if (PlayerPrefs.GetInt("rewardAnimal_2") == 1)
        {
            if (PlayerPrefs.GetInt("haveRated") == 0)
            {
                rateObject.SetActive(true);
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Rate()
    {
        PlayerPrefs.SetInt("haveRated", 1);
        Application.OpenURL("https://thebarriepatch.com/about-us");
        rateObject.SetActive(false);
        /* Replace open url with: 
         * Application.OpenURL("market://details?id=YOUR_ID");
         * replace YOUR-ID with our id
         */
        

    }

    public void Close()
    {
        rateObject.SetActive(false);
    }
}
