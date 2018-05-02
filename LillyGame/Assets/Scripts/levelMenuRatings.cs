using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelMenuRatings : MonoBehaviour {
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    public int levelNumber;//Allows different values for each level's rating
    int rating = 0;
    // Use this for initialization
    void Start () {

        Star3.SetActive(false);
        Star2.SetActive(false);
        Star1.SetActive(false);

        rating = PlayerPrefs.GetInt("rating_" + levelNumber);

        if (rating == 1)
        {
            Star3.SetActive(false);
            Star2.SetActive(false);
            Star1.SetActive(false);
        }
        if (rating == 2)
        {
            Star3.SetActive(false);
            Star2.SetActive(false);
            Star1.SetActive(true);
        }
        if (rating == 3)
        {
            Star3.SetActive(false);
            Star2.SetActive(true);
            Star1.SetActive(true);
        }
        if (rating == 4)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
