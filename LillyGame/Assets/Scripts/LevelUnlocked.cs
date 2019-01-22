using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelUnlocked : MonoBehaviour {
    public static int level=1;
    public int max_level;
    public GameObject[] levelUnlocked;
    public GameObject ResetCheckPanel;


    
	// Use this for initialization
	void Start () {
        ResetCheckPanel.SetActive(false);
        level = PlayerPrefs.GetInt("level", level);
	}
	
	// Update is called once per frame
	void Update () {
       
      
        for (int i = 1; i < max_level; i++)
        {

            if (i <= level)
            {
                levelUnlocked[i].SetActive(false);
               
                
            }
            else
            {
                levelUnlocked[i].SetActive(true);
               
            }
        }
        
	}
    public static void Next_Level()
    {
        if (level == Ne_Level.thelevel)
        {
            level += 1;
            PlayerPrefs.SetInt("level", level);
        }
            
       
       
    }
    public void ResetCheck()
    {
        ResetCheckPanel.SetActive(true);
    }
    public void Reset()
    {
        level = 1;
        PlayerPrefs.SetInt("level", level);
        for (int i = 1; i <= 10; i++)
        {
            PlayerPrefs.SetInt("rating_" + i, 1); // Set level-select stars to blank.
            PlayerPrefs.SetInt("rewardAnimal_" + i, 0); //Set main menu reward animals to blank.
       }
        PlayerPrefs.SetInt("hasSeenInfoPanel", 0);
        PlayerPrefs.SetInt("hasSeenInfoPanel2", 0);
        PlayerPrefs.SetInt("hasSeenInfoPanel3", 0);
        PlayerPrefs.SetInt("rateDelay", 0);
        PlayerPrefs.SetInt("Lilly", 1); //Set Lilly Sprite to default
    }


}
