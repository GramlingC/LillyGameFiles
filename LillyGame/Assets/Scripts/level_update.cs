using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level_update : MonoBehaviour {

    public Button level_button;
    public int levelNumber;//Allows different values for each level's rating
    //SpriteRenderer RewardSprite;
    int reward;



    // Use this for initialization
    void Start()
    {
        level_button = GetComponent<Button>();
        level_button.enabled = false;

        if (PlayerPrefs.GetInt("rewardAnimal_" + levelNumber) == 1)
        {
            level_button.enabled = true;
        }
    }
}
