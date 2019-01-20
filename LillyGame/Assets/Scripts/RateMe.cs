using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateMe : MonoBehaviour {

    public GameObject rateObject;
    private int delayCountdown;

	// Use this for initialization
	void Start () {
        rateObject.SetActive(false);
        //PlayerPrefs.SetInt("haveRated", 0);//debugging
        delayCountdown = PlayerPrefs.GetInt("rateDelay");
        delayCountdown--;
        PlayerPrefs.SetInt("rateDelay", delayCountdown);

        if (PlayerPrefs.GetInt("rewardAnimal_2") == 1) //If level two is complete
        {
            Debug.Log("reward animal2=1");
            if (PlayerPrefs.GetInt("rateDelay") <= 0) //If it's been a while since they said "no"
            {
                Debug.Log("countdown>=0");
                if (PlayerPrefs.GetInt("haveRated") == 0) //If they haven't rated yet.
                {
                    Debug.Log("rateactivated");
                
                    rateObject.SetActive(true);

                }
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
        PlayerPrefs.SetInt("rateDelay", 3); //Sets the countdown so popup doesn't open 
                                            //everytime the object is started
        rateObject.SetActive(false);
    }
}
