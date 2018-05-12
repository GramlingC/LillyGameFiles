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

    }
	
	// Update is called once per frame
	void Update () {
        SetRatings();
	}

    public void SetRatings()
    {
        Star3.SetActive(false);
        Star2.SetActive(false);
        Star1.SetActive(false);


        rating = PlayerPrefs.GetInt("rating_" + levelNumber);

        switch (rating)
        {
            case 1:
                Star3.SetActive(false);
                Star2.SetActive(false);
                Star1.SetActive(false);
                break;

            case 2:
                Star3.SetActive(false);
                Star2.SetActive(false);
                Star1.SetActive(true);
                break;

            case 3:
                Star3.SetActive(false);
                Star2.SetActive(true);
                Star1.SetActive(true);
                break;

            case 4:
                Star1.SetActive(true);
                Star2.SetActive(true);
                Star3.SetActive(true);
                break;
        }
       
    }

}
