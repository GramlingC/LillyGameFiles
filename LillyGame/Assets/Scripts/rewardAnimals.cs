using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rewardAnimals : MonoBehaviour {
    public GameObject RewardAnimal;
    public int levelNumber;//Allows different values for each level's rating
    SpriteRenderer RewardSprite;
    AudioSource AudioSource;
    


    // Use this for initialization
    void Start () {
        RewardSprite = GetComponent<SpriteRenderer>();
        RewardSprite.enabled = false;
        AudioSource = GetComponent<AudioSource>();

        if (PlayerPrefs.GetInt("rewardAnimal_" + levelNumber) == 1)
        {
            RewardSprite.enabled = true;
        }
    }

    private void OnMouseDown()
    {
        if (RewardSprite.enabled == true)
        { 
            AudioSource.Play();
        }
    }
    // Update is called once per frame
    void Update () {

	}
}
