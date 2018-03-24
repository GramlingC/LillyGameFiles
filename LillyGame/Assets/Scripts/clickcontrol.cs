using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickcontrol : MonoBehaviour {

    public static string nameofobj;
    //whatever prompt we are using for the level, image or text
    public GameObject objhintprompt;
    public Transform successclick;
    public AudioSource AudioSource;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
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
