using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratingSystem : MonoBehaviour {


    public  GameObject Star1;
    public  GameObject Star2;
    public  GameObject Star3;

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
        }
        if (movetowards.times >= 4)
        {
            Star2.SetActive(false);
        }
        if (movetowards.times >= 2)
        {
            Star3.SetActive(false);
        }
    }
    
}
