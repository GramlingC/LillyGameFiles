using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YarnTrail : MonoBehaviour {

    public GameObject ball;
    bool activated = false;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update ()
    { 
        if (ball.transform.position.x - this.transform.position.x < .05 && !activated)
        {
            activated = this.GetComponent<SpriteRenderer>().enabled = true;
        }
	}

    public void resetTrail()
    {
        activated = this.GetComponent<SpriteRenderer>().enabled = false;
    }
}
