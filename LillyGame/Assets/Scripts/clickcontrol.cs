using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickcontrol : MonoBehaviour {

    public static string nameofobj;
    //whatever prompt we are using for the level, image or text
    public GameObject objhintprompt;
    public Transform successclick;
    public Transform hintsparkling;
    public AudioSource AudioSource;

    public int randNumb = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(movetowards.hintused == "y")
        {
            randNumb = Random.Range(1, 7);
            if((gameObject.name == "Bunny1") && (randNumb == 1))
            {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
            if ((gameObject.name == "Cow1") && (randNumb == 2))
            {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
            if ((gameObject.name == "Rooster1") && (randNumb == 3))
            {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
            if ((gameObject.name == "Horse1") && (randNumb == 4))
            {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
            if ((gameObject.name == "Butterfly1") && (randNumb == 5))
            {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
            if ((gameObject.name == "Snake1") && (randNumb == 6))
            {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
            if ((gameObject.name == "Trowel1") && (randNumb == 7))
            {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
        }
	}

    void OnMouseDown()
    {
        nameofobj = gameObject.name;
        /* for debugging porposes
          Debug.Log(nameofobj); */
        Destroy(gameObject);
        AudioSource.Play();
        //Keep track of useless click
        trackingclicks.totalclicks = 0;
        //Particle effect where text used to be
        Instantiate(successclick, objhintprompt.transform.position, successclick.rotation);
    }
}
