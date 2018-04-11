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

    public GameObject[] TargetObjects;


	// Use this for initialization
	void Start () {
        //Scan the scene for tagged gameobjects and put them into that array
        TargetObjects = GameObject.FindGameObjectsWithTag("TargetObject");
    }
	
	// Update is called once per frame
	void Update () {
        if (movetowards.hintused == "y")
        {

            //Tim S. - I modified Diana's code to be more modular. Able to use it across all scenes
            //Randomly selects one of the game objects from the array.
            if (gameObject == TargetObjects[Random.Range(0, TargetObjects.Length)])
                {
                Instantiate(hintsparkling, gameObject.transform.position, hintsparkling.rotation);
                movetowards.hintused = "n";
            }
        }
        destroyClone();
	}
    void destroyClone()
    {
        Destroy(GameObject.Find("ring(Clone)"),2f);

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
