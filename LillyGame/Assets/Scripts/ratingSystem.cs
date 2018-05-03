using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratingSystem : MonoBehaviour {


    public  GameObject Star1;
    public  GameObject Star2;
    public  GameObject Star3;
    public  int levelNumber;//Allows different values for each level's rating

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
        if (movetowards.times >= 6)
        {
            Star1.SetActive(false);
            PlayerPrefs.SetInt("rating_" + levelNumber, 1);
        }
        if (movetowards.times >= 4)
        {
            Star2.SetActive(false);
            PlayerPrefs.SetInt("rating_" + levelNumber, 2);
        }
        if (movetowards.times >= 2)
        {
            Star3.SetActive(false);
            PlayerPrefs.SetInt("rating_" + levelNumber, 3);
        }
        if (movetowards.times < 2)
        {
            PlayerPrefs.SetInt("rating_" + levelNumber, 4);
        }
    }

}
