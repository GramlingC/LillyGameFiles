using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratingSystem : MonoBehaviour {


    public  GameObject Star1;
    public  GameObject Star2;
    public  GameObject Star3;
    public  int levelNumber;//Allows different values for each level's rating
    int rating = 0;// compare in-game score to high score

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        ratingStar();
    }
    void ratingStar()
    {
        if (movetowards.times < 2)
        {
            rating = 4;            
        }
        if (movetowards.times >= 2)
        {
            Star3.SetActive(false);
            rating = 3;            
        }
        if (movetowards.times >= 4)
        {
            Star2.SetActive(false);
            rating = 2;            
        }
        if (movetowards.times >= 6)
        {
            Star1.SetActive(false);
            rating = 1;            
        }

        //Only save the greater score
        if (PlayerPrefs.GetInt("rating_" + levelNumber) < rating)
        {
            PlayerPrefs.SetInt("rating_" + levelNumber, rating);
        }



    }

}
