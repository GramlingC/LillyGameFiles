﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelUnlocked : MonoBehaviour {
    public static int level=1;
    public int max_level;
    public GameObject[] levelUnlocked;


    
	// Use this for initialization
	void Start () {
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
    public void Reset()
    {
        level = 1;
        PlayerPrefs.SetInt("level", level);
        for (int i = 1; i <= 10; i++)
        {
            PlayerPrefs.SetInt("rating_" + i, 1); // Set level-select stars to blank.
            PlayerPrefs.SetInt("rewardAnimal_" + i, 0); //Set main menu reward animals to blank.
       }
    }

   
}
