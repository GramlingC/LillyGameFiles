using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rewardAnimals : MonoBehaviour {
    public GameObject RewardAnimal;
    public int levelNumber;//Allows different values for each level's rating
    SpriteRenderer RewardSprite;
    int reward;



    // Use this for initialization
    void Start () {
        RewardSprite = GetComponent<SpriteRenderer>();
        RewardSprite.enabled = false;

        if (PlayerPrefs.GetInt("rewardAnimal_" + levelNumber) == 1)
        {
            RewardSprite.enabled = true;
        }
    }
	
	// Update is called once per frame
	void Update () {

	}
}
