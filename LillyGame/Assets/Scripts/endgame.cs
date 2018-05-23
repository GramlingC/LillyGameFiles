using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour {
    public GameObject nextlevel_panel;
    public LillyHideSprite lillySprite; //gameobject with script must be referenced in editor
    public int levelNumber;//Allows different values for each level's rating

    // Use this for initialization
    void Start () {
        nextlevel_panel.SetActive(false);
        lillySprite.sprite = PlayerPrefs.GetInt("Lilly", lillySprite.sprite);
    }
	
	// Update is called once per frame
	void Update () {
        //End Game if all tagged objects are gone
        if (GameObject.FindGameObjectsWithTag("TargetObject").Length <= 0)
        {
            //activate the "Next Level" prompt
            nextlevel_panel.SetActive(true);
            PlayerPrefs.SetInt("rewardAnimal_" + levelNumber, 1);
        }

        //Change lilly sprite based on 1, 2, or 3 key
        //Can delete
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            lillySprite.sprite = 1;
            PlayerPrefs.SetInt("Lilly", lillySprite.sprite);
            lillySprite.ChangeSprite();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            lillySprite.sprite = 2;
            PlayerPrefs.SetInt("Lilly", lillySprite.sprite);
            lillySprite.ChangeSprite();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            lillySprite.sprite = 3;
            PlayerPrefs.SetInt("Lilly", lillySprite.sprite);
            lillySprite.ChangeSprite();
        }

    }
}
