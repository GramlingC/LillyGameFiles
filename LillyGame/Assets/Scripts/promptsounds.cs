using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class promptsounds : MonoBehaviour {


    public AudioSource AudioSource;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        AudioSource.Play();
    }

}
